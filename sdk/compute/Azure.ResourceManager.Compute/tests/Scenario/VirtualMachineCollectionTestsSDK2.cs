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

namespace Azure.ResourceManager.Compute.Tests.Exp2
{
    public class VirtualMachineCollectionTestsSDK2 : VirtualMachineTestBase
    {
        public VirtualMachineCollectionTestsSDK2(bool async)
            : base(async, RecordedTestMode.Record)
        {
        }
        public ResourceIdentifier nicId;

        [SetUp]
        public async Task Setup()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            _genericResourceCollection = Client.GetGenericResources();
            _resourceGroup = await CreateResourceGroupAsync();
            var nic = await CreateBasicDependenciesOfVirtualMachineAsync();
            nicId = nic.Id;

            await CreateBasicDependenciesOfVirtualMachineAsync();
            await CreateBasicDependenciesOfVirtualMachineAsync();

            stopwatch.Stop();
            Console.WriteLine("SDK::Setup: Elapsed Time is {0} s", stopwatch.Elapsed.TotalSeconds);
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
            Console.WriteLine("SDK::CreateOrUpdate: Elapsed Time is {0} s", stopwatch.Elapsed.TotalSeconds);
        }
    }
}
