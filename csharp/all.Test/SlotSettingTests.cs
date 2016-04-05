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
    ///  Class for testing SlotSetting
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SlotSettingTests
    {
        private SlotSetting instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SlotSetting();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SlotSetting
        /// </summary>
        [Test]
        public void SlotSettingInstanceTest()
        {
            Assert.IsInstanceOf<SlotSetting> (instance, "instance is a SlotSetting");
        }

        
        /// <summary>
        /// Test the property 'Interval' 
        /// </summary>
        [Test]
        public void IntervalTest()
        {
            // TODO: unit test for the property 'Interval' 
        }
        
        /// <summary>
        /// Test the property 'MaxCoversPerSlot' 
        /// </summary>
        [Test]
        public void MaxCoversPerSlotTest()
        {
            // TODO: unit test for the property 'MaxCoversPerSlot' 
        }
        

    }

}

