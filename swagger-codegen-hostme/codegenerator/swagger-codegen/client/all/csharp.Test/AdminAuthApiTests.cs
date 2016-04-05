using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using HostMe.Sdk.Client;
using HostMe.Sdk.Api;
using HostMe.Sdk.Model;


namespace HostMe.Sdk.Test
{
    /// <summary>
    ///  Class for testing AdminAuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AdminAuthApiTests
    {
        private AdminAuthApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new AdminAuthApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdminAuthApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AdminAuthApi> (instance, "instance is a AdminAuthApi");
        }

        
        /// <summary>
        /// Test ConfirmEmail
        /// </summary>
        [Test]
        public void ConfirmEmailTest()
        {
            // TODO: add unit test for the method 'ConfirmEmail'
            string userId = null; // TODO: replace null with proper value
            string code = null; // TODO: replace null with proper value
            
            var response = instance.ConfirmEmail(userId, code);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test GetExternalLogin
        /// </summary>
        [Test]
        public void GetExternalLoginTest()
        {
            // TODO: add unit test for the method 'GetExternalLogin'
            string provider = null; // TODO: replace null with proper value
            string error = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalLogin(provider, error);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test GetExternalLogin1
        /// </summary>
        [Test]
        public void GetExternalLogin1Test()
        {
            // TODO: add unit test for the method 'GetExternalLogin1'
            string accessToken = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalLogin1(accessToken);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test GetExternalLogins
        /// </summary>
        [Test]
        public void GetExternalLoginsTest()
        {
            // TODO: add unit test for the method 'GetExternalLogins'
            string returnUrl = null; // TODO: replace null with proper value
            bool? generateState = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalLogins(returnUrl, generateState);
            Assert.IsInstanceOf<List<ExternalLoginViewModel>> (response, "response is List<ExternalLoginViewModel>"); 
        }
        
    }

}
