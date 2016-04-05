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
    ///  Class for testing WaitingsStatDimensions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class WaitingsStatDimensionsTests
    {
        private WaitingsStatDimensions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WaitingsStatDimensions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WaitingsStatDimensions
        /// </summary>
        [Test]
        public void WaitingsStatDimensionsInstanceTest()
        {
            Assert.IsInstanceOf<WaitingsStatDimensions> (instance, "instance is a WaitingsStatDimensions");
        }

        
        /// <summary>
        /// Test the property 'Time' 
        /// </summary>
        [Test]
        public void TimeTest()
        {
            // TODO: unit test for the property 'Time' 
        }
        
        /// <summary>
        /// Test the property 'GroupSize' 
        /// </summary>
        [Test]
        public void GroupSizeTest()
        {
            // TODO: unit test for the property 'GroupSize' 
        }
        
        /// <summary>
        /// Test the property 'TopSize' 
        /// </summary>
        [Test]
        public void TopSizeTest()
        {
            // TODO: unit test for the property 'TopSize' 
        }
        
        /// <summary>
        /// Test the property 'LinePosition' 
        /// </summary>
        [Test]
        public void LinePositionTest()
        {
            // TODO: unit test for the property 'LinePosition' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        

    }

}

