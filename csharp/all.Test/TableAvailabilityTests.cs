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
    ///  Class for testing TableAvailability
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TableAvailabilityTests
    {
        private TableAvailability instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TableAvailability();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TableAvailability
        /// </summary>
        [Test]
        public void TableAvailabilityInstanceTest()
        {
            Assert.IsInstanceOf<TableAvailability> (instance, "instance is a TableAvailability");
        }

        
        /// <summary>
        /// Test the property 'MinCoversRequired' 
        /// </summary>
        [Test]
        public void MinCoversRequiredTest()
        {
            // TODO: unit test for the property 'MinCoversRequired' 
        }
        
        /// <summary>
        /// Test the property 'Reservable' 
        /// </summary>
        [Test]
        public void ReservableTest()
        {
            // TODO: unit test for the property 'Reservable' 
        }
        
        /// <summary>
        /// Test the property 'Hours' 
        /// </summary>
        [Test]
        public void HoursTest()
        {
            // TODO: unit test for the property 'Hours' 
        }
        

    }

}

