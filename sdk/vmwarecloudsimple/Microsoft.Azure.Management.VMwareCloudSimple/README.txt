Current status of work:
-----------------------

SDK generated.
Layout for authoring tests ready.

Future work:
Authoring tests.

How to setup:

1. Setup azure-sdk-for-net repo by following https://github.com/Azure/adx-documentation-pr/blob/master/engineering/adx_netsdk_process.md.
2. Copy the vmwarecloudsimple folder in azure-sdk-for-net/sdk
3. Build from Developer command prompt:
	i. msbuild eng/mgmt.proj /t:Build /p:Scope=VMwareCloudSimple
	ii. msbuild eng/mgmt.proj /t:CreateNugetPackage /p:Scope=VMwareCloudSimple (will build Compute SDK, run tests and create Compute Nuget package. The package is created under binaries\packages)
	iii. msbuild eng/mgmt.proj /t:CreateNugetPackage /p:Scope=VMwareCloudSimple /p:SkipTests=true (will build Compute SDK, skip running tests and finally will create Compute nuget package)


Testing:

Environment variables need to be set before opening Visual Studio by:

Interactive login:
In Powershell, run:
$Env:TEST_CSM_ORGID_AUTHENTICATION = "SubscriptionId=<subscription_id>;AADTenant=<tenand_id>;Environment=AzureCloud;HttpRecorderMode=Record;";
 $Env:AZURE_TEST_MODE="Record";
Start-Process "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\devenv.exe"


Recording tests with ServicePrincipal

$Env:TEST_CSM_ORGID_AUTHENTICATION= "SubscriptionId=<subscription_id>;ServicePrincipal=<service-principal-app-id>;ServicePrincipalSecret=<service-principle-secret>;AADTenant=<tenand_id>;Environment=AzureCloud;HttpRecorderMode=Record;";
 $Env:AZURE_TEST_MODE="Record";
Start-Process "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\devenv.exe"

Tests can be run in visual studio after this.