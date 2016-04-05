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
    ///  Class for testing HourlyInterval
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HourlyIntervalTests
    {
        private HourlyInterval instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HourlyInterval();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of HourlyInterval
        /// </summary>
        [Test]
        public void HourlyIntervalInstanceTest()
        {
            Assert.IsInstanceOf<HourlyInterval> (instance, "instance is a HourlyInterval");
        }

        
        /// <summary>
        /// Test the property 'Close' 
        /// </summary>
        [Test]
        public void CloseTest()
        {
            // TODO: unit test for the property 'Close' 
        }
        
        /// <summary>
        /// Test the property 'Open' 
        /// </summary>
        [Test]
        public void OpenTest()
        {
            // TODO: unit test for the property 'Open' 
        }
        

    }

}

