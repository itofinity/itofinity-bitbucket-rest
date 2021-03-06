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
    ///  Class for testing DeployApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DeployApiTests
    {
        private string hostUrl = "";
        private string userAgent = "Itofinity.Bitbucket.Rest.Test.DeployApiTests";

        private IDeployApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = RestService.For<IDeployApi>(hostUrl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DeployApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DeployApi
            //Assert.IsInstanceOfType(typeof(DeployApi), instance, "instance is a DeployApi");
        }

        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugDeployKeysGet
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugDeployKeysGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string repo_slug = null;
            //var response = await instance.RepositoriesUsernameRepoSlugDeployKeysGet(userAgent, username, repo_slug);
            //Assert.IsInstanceOf<DeployKey> (response, "response is DeployKey");
        }
        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugDeployKeysKeyIdDelete
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugDeployKeysKeyIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string repo_slug = null;
            //string key_id = null;
            //instance.RepositoriesUsernameRepoSlugDeployKeysKeyIdDelete(userAgent, username, repo_slug, key_id);
            
        }
        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugDeployKeysKeyIdGet
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugDeployKeysKeyIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string repo_slug = null;
            //string key_id = null;
            //var response = await instance.RepositoriesUsernameRepoSlugDeployKeysKeyIdGet(userAgent, username, repo_slug, key_id);
            //Assert.IsInstanceOf<DeployKey> (response, "response is DeployKey");
        }
        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugDeployKeysKeyIdPut
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugDeployKeysKeyIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string repo_slug = null;
            //string key_id = null;
            //var response = await instance.RepositoriesUsernameRepoSlugDeployKeysKeyIdPut(userAgent, username, repo_slug, key_id);
            //Assert.IsInstanceOf<DeployKey> (response, "response is DeployKey");
        }
        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugDeployKeysPost
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugDeployKeysPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string repo_slug = null;
            //var response = await instance.RepositoriesUsernameRepoSlugDeployKeysPost(userAgent, username, repo_slug);
            //Assert.IsInstanceOf<DeployKey> (response, "response is DeployKey");
        }
        
    }

}
