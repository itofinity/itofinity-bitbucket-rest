/* 
 * Bitbucket API
 *
 * Code against the Bitbucket API to automate simple tasks, embed Bitbucket data into your own site, build mobile or desktop apps, or even add custom UI add-ons into Bitbucket itself using the Connect framework.
 *
 * OpenAPI spec version: 2.0
 * Contact: support@bitbucket.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Refit;

using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Model;

namespace Itofinity.Bitbucket.Rest.Test
{
    /// <summary>
    ///  Class for testing SnippetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SnippetApiTests
    {
        private string hostUrl = "";
        private string userAgent = "Itofinity.Bitbucket.Rest.Test.SnippetApiTests";

        private ISnippetApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = RestService.For<ISnippetApi>(hostUrl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SnippetApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SnippetApi
            //Assert.IsInstanceOfType(typeof(SnippetApi), instance, "instance is a SnippetApi");
        }

        
        /// <summary>
        /// Test SnippetsUsernameEncodedIdFilesPathGet
        /// </summary>
        [Test]
        public async void SnippetsUsernameEncodedIdFilesPathGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string path = null;
            //string encoded_id = null;
            //instance.SnippetsUsernameEncodedIdFilesPathGet(userAgent, username, path, encoded_id);
            
        }
        
    }

}
