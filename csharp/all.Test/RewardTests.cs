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
    ///  Class for testing Reward
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RewardTests
    {
        private Reward instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Reward();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Reward
        /// </summary>
        [Test]
        public void RewardInstanceTest()
        {
            Assert.IsInstanceOf<Reward> (instance, "instance is a Reward");
        }

        
        /// <summary>
        /// Test the property 'Conditions' 
        /// </summary>
        [Test]
        public void ConditionsTest()
        {
            // TODO: unit test for the property 'Conditions' 
        }
        
        /// <summary>
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'ImageUrl' 
        /// </summary>
        [Test]
        public void ImageUrlTest()
        {
            // TODO: unit test for the property 'ImageUrl' 
        }
        
        /// <summary>
        /// Test the property 'PriceInPoints' 
        /// </summary>
        [Test]
        public void PriceInPointsTest()
        {
            // TODO: unit test for the property 'PriceInPoints' 
        }
        
        /// <summary>
        /// Test the property 'Value' 
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO: unit test for the property 'Value' 
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

