// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Net;
using Microsoft.Azure.Management.VMwareCloudSimple;
using Xunit;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.VMwareCloudSimple.Models;
using VMwareCloudSimple.Tests.Helpers;

namespace VMwareCloudSimple.Tests.ScenarioTests
{
    public class GetVMwareVMTests
    {
        [Fact]
        public void GetVMwareVMTest()
        {

            var handler1 = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };
            var handler2 = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (MockContext context = MockContext.Start(this.GetType()))
            {
                // Create clients
                var VMwareCloudSimpleMgmtClient = VMwareCloudSimpleTestUtilities.GetVMwareCloudSimpleClient(context, handler1);
                var resourcesClient = VMwareCloudSimpleTestUtilities.GetResourceManagementClient(context, handler2);

                // Author test here:

                // var VMs = VMwareCloudSimpleMgmtClient.VirtualMachines.ListBySubscription();
                // foreach(var vm in VMs)
                // {
                //     Assert.True(vm.AmountOfRam > 0);
                // }

            }
        }
    }
}
