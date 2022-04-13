// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute.Tests.Helpers;
using NUnit.Framework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Tests
{
    public class VirtualMachineCollectionTests : VirtualMachineTestBase
    {
        public VirtualMachineCollectionTests(bool async)
            : base(async, RecordedTestMode.Record)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            string vmName = Recording.GenerateAssetName("testVM-");
            VirtualMachineResource virtualMachine = await CreateVirtualMachineAsync(vmName);
            Assert.AreEqual(vmName, virtualMachine.Data.Name);
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateVMByArmTemplate()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var templatePayload = $@"                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {{
  ""$schema"": ""https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#"",
  ""contentVersion"": ""1.0.0.0"",
  ""metadata"": {{
  }},
  ""parameters"": {{
    ""location"": {{
      ""type"": ""string"",
      ""defaultValue"": ""[resourceGroup().location]"",
      ""metadata"": {{
        ""description"": ""Location for all resources.""
      }}
    }},
    ""vmName"": {{
      ""type"": ""string"",
      ""defaultValue"": ""simple-vm"",
      ""metadata"": {{
        ""description"": ""Name of the virtual machine.""
      }}
    }}
  }},
   ""variables"": {{
    ""storageAccountName"": ""[format('bootdiags{{0}}', uniqueString(resourceGroup().id))]"",
    ""nicName"": ""myVMNic"",
    ""addressPrefix"": ""10.0.0.0/16"",
    ""subnetName"": ""Subnet"",
    ""subnetPrefix"": ""10.0.2.0/24"",
    ""virtualNetworkName"": ""MyVNET""
  }},
  ""resources"": [
    {{
      ""type"": ""Microsoft.Network/virtualNetworks"",
      ""apiVersion"": ""2021-02-01"",
      ""name"": ""[variables('virtualNetworkName')]"",
      ""location"": ""[parameters('location')]"",
      ""properties"": {{
        ""addressSpace"": {{
          ""addressPrefixes"": [
            ""[variables('addressPrefix')]""
          ]
        }},
        ""subnets"": [
          {{
            ""name"": ""[variables('subnetName')]"",
            ""properties"": {{
              ""addressPrefix"": ""[variables('subnetPrefix')]""
            }}
          }}
        ]
      }},
      ""dependsOn"": [
      ]
    }},
    {{
      ""type"": ""Microsoft.Network/networkInterfaces"",
      ""apiVersion"": ""2021-02-01"",
      ""name"": ""[variables('nicName')]"",
      ""location"": ""[parameters('location')]"",
      ""properties"": {{
        ""ipConfigurations"": [
          {{
            ""name"": ""ipconfig1"",
            ""properties"": {{
              ""subnet"": {{
                ""id"": ""[resourceId('Microsoft.Network/virtualNetworks/subnets', variables('virtualNetworkName'), variables('subnetName'))]""
              }}
            }}
          }}
        ]
      }},
      ""dependsOn"": [
        ""[resourceId('Microsoft.Network/virtualNetworks', variables('virtualNetworkName'))]""
      ]
    }},
    {{
      ""type"": ""Microsoft.Compute/virtualMachines"",
      ""apiVersion"": ""2021-07-01"",
      ""name"": ""[parameters('vmName')]"",
      ""location"": ""[parameters('location')]"",
      ""properties"": {{
        ""hardwareProfile"": {{
          ""vmSize"": ""Standard_F2""
        }},
        ""osProfile"": {{
          ""computerName"": ""[parameters('vmName')]"",
          ""adminUsername"": ""adminuser"",
          ""linuxConfiguration"":{{
            ""disablePasswordAuthentication"":true,
            ""ssh"":{{
               ""publicKeys"":[
                  {{
                     ""path"":""/home/adminuser/.ssh/authorized_keys"",
                     ""keyData"":""ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQC\u002BwWK73dCr\u002BjgQOAxNsHAnNNNMEMWOHYEccp6wJm2gotpr9katuF/ZAdou5AaW1C61slRkHRkpRRX9FA9CYBiitZgvCCz\u002B3nWNN7l/Up54Zps/pHWGZLHNJZRYyAB6j5yVLMVHIHriY49d/GZTZVNB8GoJv9Gakwc/fuEZYYl4YDFiGMBP///TzlI4jhiJzjKnEvqPFki5p2ZRJqcbCiF4pJrxUQR/RXqVFQdbRLZgYfJ8xGB878RENq3yQ39d8dVOkq4edbkzwcUmwwwkYVPIoDGsYLaRHnG\u002BTo7FvMeyO7xDVQkMKzopTQV8AuKpyvpqu0a9pWOMaiCyDytO7GGN you@me.com""
                  }}
               ]
            }}
         }} 
        }},
		""storageProfile"":{{
         ""imageReference"":{{
            ""publisher"":""Canonical"",
            ""offer"":""UbuntuServer"",
            ""sku"":""16.04-LTS"",
            ""version"":""latest""
         }},
         ""osDisk"":{{
            ""osType"":""Linux"",
            ""caching"":""ReadWrite"",
            ""createOption"":""FromImage"",
            ""managedDisk"":{{
               ""storageAccountType"":""Standard_LRS""
            }}
         }}
        }},
        ""networkProfile"": {{
          ""networkInterfaces"": [
            {{
              ""id"": ""[resourceId('Microsoft.Network/networkInterfaces', variables('nicName'))]"",
			  ""properties"":{{
                  ""primary"":true
               }}
            }}
          ]
        }}
      }},
      ""dependsOn"": [
        ""[resourceId('Microsoft.Network/networkInterfaces', variables('nicName'))]""
      ]
    }}
  ],
  ""outputs"": {{
  }}
}}";
                var deploymentOperation = await resourceGroup.GetArmDeployments().CreateOrUpdateAsync(WaitUntil.Completed, "Generate_Unique_Name", new ArmDeploymentContent(new Resources.Models.ArmDeploymentProperties(ArmDeploymentMode.Complete)
                {
                    Template = BinaryData.FromString(templatePayload),
                }));
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            var collection = await GetVirtualMachineCollectionAsync();
            var vmName = Recording.GenerateAssetName("testVM-");
            var nic = await CreateBasicDependenciesOfVirtualMachineAsync();
            var input = ResourceDataHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName, nic.Id);
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmName, input);
            VirtualMachineResource vm1 = lro.Value;
            VirtualMachineResource vm2 = await collection.GetAsync(vmName);

            ResourceDataHelper.AssertVirtualMachine(vm1.Data, vm2.Data);
        }

        [TestCase]
        [RecordedTest]
        public async Task Exists()
        {
            var collection = await GetVirtualMachineCollectionAsync();
            var vmName = Recording.GenerateAssetName("testVM-");
            var nic = await CreateBasicDependenciesOfVirtualMachineAsync();
            var input = ResourceDataHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName, nic.Id);
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmName, input);
            VirtualMachineResource vm = lro.Value;
            Assert.IsTrue(await collection.ExistsAsync(vmName));
            Assert.IsFalse(await collection.ExistsAsync(vmName + "1"));

            Assert.ThrowsAsync<ArgumentNullException>(async () => _ = await collection.ExistsAsync(null));
        }

        [TestCase]
        [RecordedTest]
        public async Task GetAll()
        {
            var collection = await GetVirtualMachineCollectionAsync();
            var vmName1 = Recording.GenerateAssetName("testVM-");
            var vmName2 = Recording.GenerateAssetName("testVM-");
            var nic1 = await CreateBasicDependenciesOfVirtualMachineAsync();
            var nic2 = await CreateBasicDependenciesOfVirtualMachineAsync();
            var input1 = ResourceDataHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName1, nic1.Id);
            var input2 = ResourceDataHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName2, nic2.Id);
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmName1, input1);
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmName2, input2);
            int count = 0;
            await foreach (var vm in collection.GetAllAsync())
            {
                count++;
            }
            Assert.GreaterOrEqual(count, 2);
        }

        [TestCase]
        [RecordedTest]
        public async Task GetAllInSubscription()
        {
            var collection = await GetVirtualMachineCollectionAsync();
            var vmName1 = Recording.GenerateAssetName("testVM-");
            var vmName2 = Recording.GenerateAssetName("testVM-");
            var nic1 = await CreateBasicDependenciesOfVirtualMachineAsync();
            var nic2 = await CreateBasicDependenciesOfVirtualMachineAsync();
            var input1 = ResourceDataHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName1, nic1.Id);
            var input2 = ResourceDataHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName2, nic2.Id);
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmName1, input1);
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmName2, input2);

            VirtualMachineResource vm1 = null, vm2 = null;
            await foreach (var vm in DefaultSubscription.GetVirtualMachinesAsync())
            {
                if (vm.Data.Name == vmName1)
                    vm1 = vm;
                if (vm.Data.Name == vmName2)
                    vm2 = vm;
            }

            Assert.NotNull(vm1);
            Assert.NotNull(vm2);
        }
    }
}
