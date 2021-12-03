Param(
    [string] $sdkPath,
    [string] $specPath,
    [bool] $generateSDK = $false,
    [bool] $generateTest = $false,
    [bool] $executeMockTest = $true
)

$AUTOREST_TEST_PACKAGE_URL = "@autorest/gotest@1.1.2"
$AUTOREST_GO_VERSION = "@autorest/go@4.0.0-preview.31"
$AUTOREST_CONFIG_FILE = "autorest.md"
$AUTOREST_CORE_VERSION = "3.6.2"

function executeSingleGenerate($readmePath, $sepcRPName)
{
    Write-Host "Processing Spec RP $sepcRPName ..."
    if ($sepcRPName -lt "1") {
        return
    }
    $NewString = $sepcRPName.replace("-", "")
    $capitalizedRPName = (Get-Culture).TextInfo.ToTitleCase($sepcRPName)
    $slnFolder = (Join-Path $sdkPath "sdk" $sepcRPName "Azure.ResourceManager.$capitalizedRPName")
    $srcFolder = (Join-Path $slnFolder "src")
    $testsFolder = (Join-Path $slnFolder "tests")
    $provider = "Microsoft.$capitalizedRPName"
    if (Test-Path -Path $slnFolder) {
        # Set-Location $slnFolder
    } else {
        New-Item $slnFolder -ItemType Directory -ea 0
    }

    Set-Location $slnFolder
    if (Get-ChildItem '*.sln') {
        echo "sln already exists!"
        return
    }
    dotnet new azuremgmt --provider $provider --includeCI true --force

    Set-Location $srcFolder
    autorest --use=D:\projects\codegen\autorest.csharp\artifacts\bin\AutoRest.CSharp\Debug\netcoreapp3.1 (Join-Path $srcFolder "autorest.md") --debug --csharpgen.attach=false --save-inputs && dotnet build
    if ($LASTEXITCODE)
    {
        Write-Host "##[warn] generate or build src code error for RP $sepcRPName"
        # Set-Location $sdkPath
        # Remove-Item -LiteralPath $slnFolder -Force -Recurse
        return
    }

    Set-Location $testsFolder
    autorest --use=D:\projects\codegen\autorest.csharp\artifacts\bin\AutoRest.CSharp\Debug\netcoreapp3.1 (Join-Path $testsFolder "autorest.tests.md") --testmodeler --debug --csharpgen.attach=false --save-inputs
    if ($LASTEXITCODE)
    {
        Write-Host "##[error] generate tests code error for RP $sepcRPName"
        exit
    }
    dotnet build
    if ($LASTEXITCODE)
    {
        Write-Host "##[error] build tests code error for RP $sepcRPName"
        exit
    }

    # Set-Location $sdkPath
    # Remove-Item -LiteralPath $slnFolder -Force -Recurse

#     $content = Get-Content $readmePath -Raw
#     if ($content -notmatch "\`$\(track2\)")
#     {
#         $rpName = $sepcRPName -replace "-", ""
#         $content = $content.Replace("`````` yaml `$(go)", "`````` yaml `$(go) && !`$(track2)")
#         $content += "
# ``````yaml `$(go) && `$(track2)
# license-header: MICROSOFT_MIT_NO_VERSION
# module-name: sdk/resourcemanager/$rpName/arm$rpName
# module: github.com/Azure/azure-sdk-for-go/`$(module-name)
# output-folder: `$(go-sdk-folder)/`$(module-name)
# azure-arm: true
# modelerfour:
#   lenient-model-deduplication: true
# ``````
# "
#         Set-Content (Join-Path $specPath "specification" $sepcRPName "resource-manager" "readme.go.md") $content
#         $packageName = "arm$rpName"
#     }
#     else
#     {
#         $content -match "module-name: sdk\/resourcemanager\/(?<rpName>.*)\/(?<packageName>.*)"
#         $rpName = $matches["rpName"]
#         $packageName = $matches["packageName"] -replace "`n", "" -replace "`r", ""
#     }
    
#     if ($generateSDK)
#     {
#         Write-Host "Generate sdk code for RP $rpName with Package $packageName ..."
#         Write-Host "generator release-v2 $sdkPath $specPath $rpName $packageName --spec-rp-name=$sepcRPName --skip-create-branch=true"
#         generator release-v2 $sdkPath $specPath $rpName $packageName --spec-rp-name=$sepcRPName --skip-create-branch=true
#         if ($LASTEXITCODE)
#         {
#             Write-Host "##[error] generate sdk code error for RP $rpName with Package $packageName"
#             return
#         }
#         Set-Location (Join-Path $sdkPath "sdk" "resourcemanager" $rpName $packageName)
#         if (-not (checkResult "sdk code" $rpName $packageName))
#         {
#             return
#         }
#     }

    # if ($generateTest)
    # {
    #     Write-Host "Generate test code for RP $rpName with Package $packageName ..."
    #     Set-Location (Join-Path $sdkPath "sdk" "resourcemanager" $rpName $packageName)
    #     Write-Host "autorest --version=$AUTOREST_CORE_VERSION --use=$AUTOREST_GO_VERSION --use=$AUTOREST_TEST_PACKAGE_URL --file-prefix=zz_generated_ --track2 --go --output-folder=. --clear-output-folder=false --testmodeler.generate-mock-test --testmodeler.generate-sdk-example --testmodeler.generate-scenario-test --generate-sdk=false .\$AUTOREST_CONFIG_FILE"
    #     autorest --version=$AUTOREST_CORE_VERSION --use=$AUTOREST_GO_VERSION --use=$AUTOREST_TEST_PACKAGE_URL --file-prefix=zz_generated_ --track2 --go --output-folder=. --clear-output-folder=false --testmodeler.generate-mock-test --testmodeler.generate-sdk-example --testmodeler.generate-scenario-test --generate-sdk=true .\$AUTOREST_CONFIG_FILE
    #     if ($LASTEXITCODE)
    #     {
    #         Write-Host "##[error] generation test code error for RP $rpName with Package $packageName"
    #         return
    #     }
    #     if (-not (checkResult "test code" $rpName $packageName))
    #     {
    #         return
    #     }
    # }

    # if($executeMockTest)
    # {
    #     Write-Host "Execute mock test for RP $rpName with Package $packageName ..."
    #     Set-Location (Join-Path $sdkPath "sdk" "resourcemanager" $rpName $packageName)
    #     $Env:AZURE_TENANT_ID = "mock-test"
    #     $Env:AZURE_CLIENT_ID = "mock-test"
    #     $Env:AZURE_USERNAME = "mock-test"
    #     $Env:AZURE_PASSWORD = "mock-test"
    #     go test -v -coverprofile coverage.txt
    #     if ($LASTEXITCODE)
    #     {
    #         Write-Host "##[error] execute mock test error for RP $rpName with Package $packageName"
    #         return
    #     }
    # }
}

function checkResult($checkName, $rpName, $packageName)
{
    gofmt -s -w .
    go mod tidy
    if ($LASTEXITCODE)
    {
        Write-Host "##[error] mod tidy error for $checkName of RP $rpName with Package $packageName"
        return $false
    }
    go build .
    if ($LASTEXITCODE)
    {
        Write-Host "##[error] build error for $checkName of RP $rpName with Package $packageName"
        return $false
    }
    go vet .
    if ($LASTEXITCODE)
    {
        Write-Host "##[error] vet error for $checkName of RP $rpName with Package $packageName"
        return $false
    }
    return $true
}

Write-Host "[params] $sdkPath $specPath"
Get-ChildItem -recurse -path (Join-Path $specPath "specification") -filter readme.md | ForEach-Object {
    if ($_.FullName -match "[\/|\\]specification[\/|\\](?<specRPName>.*)[\/|\\]resource-manager[\/|\\]readme.md")
    {
        Write-Host "[handle] $_"
        executeSingleGenerate $_ $matches["specRPName"]
    }
}
