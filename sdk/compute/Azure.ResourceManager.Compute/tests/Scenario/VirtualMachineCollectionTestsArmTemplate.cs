// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute.Tests.Helpers;
using NUnit.Framework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using System.Collections.Generic;
using Azure.Core;
using System.Diagnostics;
using System.Text.Json;

namespace Azure.ResourceManager.Compute.Tests.Exp
{
    public class VirtualMachineCollectionTestsArmTemplate : VirtualMachineTestBase
    {
        public VirtualMachineCollectionTestsArmTemplate(bool async)
            : base(async, RecordedTestMode.Record)
        {
        }
        public ResourceIdentifier nicId;

        [SetUp]
        public async Task Setup()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            _resourceGroup = await CreateResourceGroupAsync();
            var templatePayload = $@"{{
 ""$schema"": ""https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#"",
  ""contentVersion"": ""1.0.0.0"",
  ""metadata"": {{
    ""_generator"": {{
      ""name"": ""bicep"",
      ""version"": ""0.4.613.9944"",
      ""templateHash"": ""7822315097766237434""
    }}
  }},
  ""parameters"": {{
    ""location"": {{
      ""type"": ""string"",
      ""defaultValue"": ""[resourceGroup().location]"",
      ""metadata"": {{
        ""description"": ""Location for all resources.""
      }}
    }}
  }},
   ""variables"": {{
    ""nicName"": ""myVMNic"",
    ""addressPrefix"": ""10.0.0.0/16"",
    ""subnetName"": ""Subnet"",
    ""subnetPrefix"": ""10.0.0.0/24"",
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
    }}
  ],
  ""outputs"": {{
	  ""nicId"": {{
		  ""type"": ""string"",
		  ""value"": ""[resourceId('Microsoft.Network/networkInterfaces', variables('nicName'))]""
		}}
  }}
}}
";
            var deploymentOperation = await _resourceGroup.GetArmDeployments().CreateOrUpdateAsync(WaitUntil.Completed, "Generate_Unique_Name", new ArmDeploymentContent(new Resources.Models.ArmDeploymentProperties(ArmDeploymentMode.Complete)
            {
                Template = BinaryData.FromString(templatePayload),
            }));
            var deployOutputs = deploymentOperation.Value.Data.Properties.Outputs.ToObjectFromJson<Dictionary<string, object>>();
            if (deployOutputs.ContainsKey("nicId") && deployOutputs["nicId"] is JsonElement nameOutput)
            {
                nicId = new ResourceIdentifier(nameOutput.GetProperty("value").ToString());
            }

            stopwatch.Stop();
            Console.WriteLine("ArmTemplate::Setup: Elapsed Time is {0} s", stopwatch.Elapsed.TotalSeconds);
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string vmName = Recording.GenerateAssetName("testVM-");

            var collection = await GetVirtualMachineCollectionAsync();
            var input = ResourceDataHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName, nicId);
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmName, input);
            Assert.AreEqual(vmName, lro.Value.Data.Name);

            stopwatch.Stop();
            Console.WriteLine("ArmTemplate::CreateOrUpdate: Elapsed Time is {0} s", stopwatch.Elapsed.TotalSeconds);
        }
    }
}
