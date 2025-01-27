﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net;
using NUnit.Framework;

namespace Azure.Storage.Files.DataLake.Tests
{
    public class DataLakeUriBuilderTests : DataLakeTestBase
    {
        private readonly Uri _customUri = new Uri("https://www.customstorageurl.com");
        private readonly Uri _shortHostUri = new Uri("https://account.core.windows.net");
        private readonly Uri _ipStyleUri = new Uri("https://0.0.0.0/account");
        private readonly Uri _invalidServiceUri = new Uri("https://account.file.core.windows.net");
        private readonly Uri _blobUri = new Uri("https://account.blob.core.windows.net");
        private readonly Uri _dfsUri = new Uri("https://account.dfs.core.windows.net");

        public DataLakeUriBuilderTests(bool async)
            : base(async, null /* RecordedTestMode.Record /* to re-record */)
        {
        }

        //TODO address the flakiness of this test.
        [Test]
        public void DataLakeUriBuilder_RoundTrip()
        {
            DataLakeServiceClient serviceUri = GetServiceClient_AccountSas();
            var dataLakeUriBuilder = new DataLakeUriBuilder(serviceUri.Uri);

            Uri dataLakeUri = dataLakeUriBuilder.ToUri();

            var expectedUri = WebUtility.UrlDecode(serviceUri.Uri.AbsoluteUri);
            var actualUri = WebUtility.UrlDecode(dataLakeUri.AbsoluteUri);

            Assert.AreEqual(expectedUri, actualUri, "Flaky test -- potential signature generation issue not properly encoding space and + in the output");
        }

        [Test]
        public void DataLakeUriBuilder_AccountTest()
        {
            // Arrange
            var uriString = "https://account.blob.core.windows.net/fileSystem/path";
            var originalUri = new UriBuilder(uriString);

            // Act
            var dataLakeUriBuilder = new DataLakeUriBuilder(originalUri.Uri);
            Uri newUri = dataLakeUriBuilder.ToUri();

            // Assert
            Assert.AreEqual("https", dataLakeUriBuilder.Scheme);
            Assert.AreEqual("account.blob.core.windows.net", dataLakeUriBuilder.Host);
            Assert.AreEqual("account", dataLakeUriBuilder.AccountName);
            Assert.AreEqual(443, dataLakeUriBuilder.Port);
            Assert.AreEqual("fileSystem", dataLakeUriBuilder.FileSystemName);
            Assert.AreEqual("path", dataLakeUriBuilder.LastDirectoryOrFileName);
            Assert.AreEqual("path", dataLakeUriBuilder.DirectoryOrFilePath);
            Assert.AreEqual("", dataLakeUriBuilder.Snapshot);
            Assert.IsNull(dataLakeUriBuilder.Sas);
            Assert.AreEqual(originalUri, newUri);
        }

        [Test]
        public void DataLakeUriBuilder_ListPaths()
        {
            // Arrange
            var uriString = "https://account.dfs.core.windows.net/fileSystem?resource=filesystem";
            var originalUri = new UriBuilder(uriString);

            // Act
            var dataLakeUriBuilder = new DataLakeUriBuilder(originalUri.Uri);
            Uri newUri = dataLakeUriBuilder.ToUri();

            // Assert
            Assert.AreEqual("https", dataLakeUriBuilder.Scheme);
            Assert.AreEqual("account.dfs.core.windows.net", dataLakeUriBuilder.Host);
            Assert.AreEqual("account", dataLakeUriBuilder.AccountName);
            Assert.AreEqual(443, dataLakeUriBuilder.Port);
            Assert.AreEqual("fileSystem", dataLakeUriBuilder.FileSystemName);
            Assert.AreEqual(string.Empty, dataLakeUriBuilder.LastDirectoryOrFileName);
            Assert.AreEqual(string.Empty, dataLakeUriBuilder.DirectoryOrFilePath);
            Assert.AreEqual("", dataLakeUriBuilder.Snapshot);
            Assert.IsNull(dataLakeUriBuilder.Sas);
            Assert.AreEqual("resource=filesystem", dataLakeUriBuilder.Query);
            Assert.AreEqual(originalUri, newUri);
        }

        [Test]
        public void DataLakeUriBuilder_RegularUrl_CNAME()
        {
            var dataLakeUriBuilder = new DataLakeUriBuilder(new Uri("http://www.contoso.com"));
            Assert.AreEqual(string.Empty, dataLakeUriBuilder.AccountName);
        }

        [Test]
        public void DataLakeUriBuilder_MalformedSubdomain()
        {
            // core and file swapped
            var datalakeUriBuilder1 = new DataLakeUriBuilder(new Uri("https://account.core.blob.windows.net/share/dir"));

            // account and file swapped
            var datalakeUriBuilder2 = new DataLakeUriBuilder(new Uri("https://blob.account.core.windows.net/share/dir"));

            // wrong service
            var datalakeUriBuilder3 = new DataLakeUriBuilder(new Uri("https://account.queue.core.windows.net/share/dir"));

            // empty service
            var datalakeUriBuilder4 = new DataLakeUriBuilder(new Uri("https://account./share/dir"));

            Assert.AreEqual(string.Empty, datalakeUriBuilder1.AccountName);
            Assert.AreEqual(string.Empty, datalakeUriBuilder2.AccountName);
            Assert.AreEqual(string.Empty, datalakeUriBuilder3.AccountName);
            Assert.AreEqual(string.Empty, datalakeUriBuilder4.AccountName);
        }

        [Test]
        public void DataLakeUriBuilder_ToBlobUri_CustomUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_customUri);

            // Act
            Uri result = uriBuilder.ToBlobUri();

            // Assert
            Assert.AreEqual(_customUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToBlobUri_ShortHost()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_shortHostUri);

            // Act
            Uri result = uriBuilder.ToBlobUri();

            // Assert
            Assert.AreEqual(_shortHostUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToBlobUri_IpStyleUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_ipStyleUri);

            // Act
            Uri result = uriBuilder.ToBlobUri();

            // Assert
            Assert.AreEqual(_ipStyleUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToBlobUri_InvalidServiceUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_invalidServiceUri);

            // Act
            Uri result = uriBuilder.ToBlobUri();

            // Assert
            Assert.AreEqual(_invalidServiceUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToBlobUri_BlobUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_blobUri);

            // Act
            Uri result = uriBuilder.ToBlobUri();

            // Assert
            Assert.AreEqual(_blobUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToBlobUri_DfsUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_dfsUri);

            // Act
            Uri result = uriBuilder.ToBlobUri();

            // Assert
            Assert.AreEqual(_blobUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToDfsUri_CustomUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_customUri);

            // Act
            Uri result = uriBuilder.ToDfsUri();

            // Assert
            Assert.AreEqual(_customUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToDfsUri_ShortHost()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_shortHostUri);

            // Act
            Uri result = uriBuilder.ToDfsUri();

            // Assert
            Assert.AreEqual(_shortHostUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToDfsUri_IpStyleUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_ipStyleUri);

            // Act
            Uri result = uriBuilder.ToDfsUri();

            // Assert
            Assert.AreEqual(_ipStyleUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToDfsUri_InvalidServiceUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_invalidServiceUri);

            // Act
            Uri result = uriBuilder.ToDfsUri();

            // Assert
            Assert.AreEqual(_invalidServiceUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToDfsUri_DfsUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_dfsUri);

            // Act
            Uri result = uriBuilder.ToDfsUri();

            // Assert
            Assert.AreEqual(_dfsUri, result);
        }

        [Test]
        public void DataLakeUriBuilder_ToDfsUri_BlobUri()
        {
            // Arrange
            DataLakeUriBuilder uriBuilder = new DataLakeUriBuilder(_blobUri);

            // Act
            Uri result = uriBuilder.ToDfsUri();

            // Assert
            Assert.AreEqual(_dfsUri, result);
        }
    }
}
