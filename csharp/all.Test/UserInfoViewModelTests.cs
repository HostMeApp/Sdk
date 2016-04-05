using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HostMe.Sdk.Api;
using HostMe.Sdk.Model;
using HostMe.Sdk.Client;
using System.Reflection;



namespace HostMe.Sdk.Test
{
    /// <summary>
    ///  Class for testing UserInfoViewModel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserInfoViewModelTests
    {
        private UserInfoViewModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserInfoViewModel();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserInfoViewModel
        /// </summary>
        [Test]
        public void UserInfoViewModelInstanceTest()
        {
            Assert.IsInstanceOf<UserInfoViewModel> (instance, "instance is a UserInfoViewModel");
        }

        
        /// <summary>
        /// Test the property 'UserName' 
        /// </summary>
        [Test]
        public void UserNameTest()
        {
            // TODO: unit test for the property 'UserName' 
        }
        
        /// <summary>
        /// Test the property 'HasRegistered' 
        /// </summary>
        [Test]
        public void HasRegisteredTest()
        {
            // TODO: unit test for the property 'HasRegistered' 
        }
        
        /// <summary>
        /// Test the property 'LoginProvider' 
        /// </summary>
        [Test]
        public void LoginProviderTest()
        {
            // TODO: unit test for the property 'LoginProvider' 
        }
        

    }

}

