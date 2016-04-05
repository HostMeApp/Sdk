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
    ///  Class for testing AvailabilityResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AvailabilityResponseTests
    {
        private AvailabilityResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AvailabilityResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AvailabilityResponse
        /// </summary>
        [Test]
        public void AvailabilityResponseInstanceTest()
        {
            Assert.IsInstanceOf<AvailabilityResponse> (instance, "instance is a AvailabilityResponse");
        }

        
        /// <summary>
        /// Test the property 'Availabilities' 
        /// </summary>
        [Test]
        public void AvailabilitiesTest()
        {
            // TODO: unit test for the property 'Availabilities' 
        }
        
        /// <summary>
        /// Test the property 'RequestedTime' 
        /// </summary>
        [Test]
        public void RequestedTimeTest()
        {
            // TODO: unit test for the property 'RequestedTime' 
        }
        
        /// <summary>
        /// Test the property 'TotalCovers' 
        /// </summary>
        [Test]
        public void TotalCoversTest()
        {
            // TODO: unit test for the property 'TotalCovers' 
        }
        
        /// <summary>
        /// Test the property 'TotalReservationCovers' 
        /// </summary>
        [Test]
        public void TotalReservationCoversTest()
        {
            // TODO: unit test for the property 'TotalReservationCovers' 
        }
        
        /// <summary>
        /// Test the property 'TotalWaitCovers' 
        /// </summary>
        [Test]
        public void TotalWaitCoversTest()
        {
            // TODO: unit test for the property 'TotalWaitCovers' 
        }
        
        /// <summary>
        /// Test the property 'UnitType' 
        /// </summary>
        [Test]
        public void UnitTypeTest()
        {
            // TODO: unit test for the property 'UnitType' 
        }
        

    }

}

