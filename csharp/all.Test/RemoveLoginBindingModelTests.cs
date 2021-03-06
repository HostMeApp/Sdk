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
    ///  Class for testing RemoveLoginBindingModel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RemoveLoginBindingModelTests
    {
        private RemoveLoginBindingModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RemoveLoginBindingModel();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RemoveLoginBindingModel
        /// </summary>
        [Test]
        public void RemoveLoginBindingModelInstanceTest()
        {
            Assert.IsInstanceOf<RemoveLoginBindingModel> (instance, "instance is a RemoveLoginBindingModel");
        }

        
        /// <summary>
        /// Test the property 'Email' 
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO: unit test for the property 'Email' 
        }
        

    }

}


