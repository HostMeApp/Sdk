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
    ///  Class for testing MinutesToPoints
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MinutesToPointsTests
    {
        private MinutesToPoints instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MinutesToPoints();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MinutesToPoints
        /// </summary>
        [Test]
        public void MinutesToPointsInstanceTest()
        {
            Assert.IsInstanceOf<MinutesToPoints> (instance, "instance is a MinutesToPoints");
        }

        
        /// <summary>
        /// Test the property 'FlatPoints' 
        /// </summary>
        [Test]
        public void FlatPointsTest()
        {
            // TODO: unit test for the property 'FlatPoints' 
        }
        
        /// <summary>
        /// Test the property 'MaxMinutes' 
        /// </summary>
        [Test]
        public void MaxMinutesTest()
        {
            // TODO: unit test for the property 'MaxMinutes' 
        }
        
        /// <summary>
        /// Test the property 'Method' 
        /// </summary>
        [Test]
        public void MethodTest()
        {
            // TODO: unit test for the property 'Method' 
        }
        
        /// <summary>
        /// Test the property 'MinMinutes' 
        /// </summary>
        [Test]
        public void MinMinutesTest()
        {
            // TODO: unit test for the property 'MinMinutes' 
        }
        
        /// <summary>
        /// Test the property 'PointsPerMinutes' 
        /// </summary>
        [Test]
        public void PointsPerMinutesTest()
        {
            // TODO: unit test for the property 'PointsPerMinutes' 
        }
        

    }

}

