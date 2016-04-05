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
    ///  Class for testing AdminTableApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AdminTableApiTests
    {
        private AdminTableApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new AdminTableApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdminTableApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AdminTableApi> (instance, "instance is a AdminTableApi");
        }

        
        /// <summary>
        /// Test CreateNewFloor
        /// </summary>
        [Test]
        public void CreateNewFloorTest()
        {
            // TODO: add unit test for the method 'CreateNewFloor'
            int? restaurantId = null; // TODO: replace null with proper value
            Floor floor = null; // TODO: replace null with proper value
            
            var response = instance.CreateNewFloor(restaurantId, floor);
            Assert.IsInstanceOf<Floor> (response, "response is Floor"); 
        }
        
        /// <summary>
        /// Test CreateOrUpdateTableConfiguration
        /// </summary>
        [Test]
        public void CreateOrUpdateTableConfigurationTest()
        {
            // TODO: add unit test for the method 'CreateOrUpdateTableConfiguration'
            int? restaurantId = null; // TODO: replace null with proper value
            List<Table> tables = null; // TODO: replace null with proper value
            
            instance.CreateOrUpdateTableConfiguration(restaurantId, tables);
             
        }
        
        /// <summary>
        /// Test DeleteFloor
        /// </summary>
        [Test]
        public void DeleteFloorTest()
        {
            // TODO: add unit test for the method 'DeleteFloor'
            int? restaurantId = null; // TODO: replace null with proper value
            string floorId = null; // TODO: replace null with proper value
            
            instance.DeleteFloor(restaurantId, floorId);
             
        }
        
        /// <summary>
        /// Test GetAllTableCombinations
        /// </summary>
        [Test]
        public void GetAllTableCombinationsTest()
        {
            // TODO: add unit test for the method 'GetAllTableCombinations'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetAllTableCombinations(restaurantId);
            Assert.IsInstanceOf<List<TableInfo>> (response, "response is List<TableInfo>"); 
        }
        
        /// <summary>
        /// Test GetApprovedTableCombinations
        /// </summary>
        [Test]
        public void GetApprovedTableCombinationsTest()
        {
            // TODO: add unit test for the method 'GetApprovedTableCombinations'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetApprovedTableCombinations(restaurantId);
            Assert.IsInstanceOf<List<TableInfo>> (response, "response is List<TableInfo>"); 
        }
        
        /// <summary>
        /// Test GetAvailableTables
        /// </summary>
        [Test]
        public void GetAvailableTablesTest()
        {
            // TODO: add unit test for the method 'GetAvailableTables'
            int? restaurantId = null; // TODO: replace null with proper value
            DateTimeOffset? date = null; // TODO: replace null with proper value
            int? partySize = null; // TODO: replace null with proper value
            string areas = null; // TODO: replace null with proper value
            
            var response = instance.GetAvailableTables(restaurantId, date, partySize, areas);
            Assert.IsInstanceOf<List<TableInfo>> (response, "response is List<TableInfo>"); 
        }
        
        /// <summary>
        /// Test GetFloorDetails
        /// </summary>
        [Test]
        public void GetFloorDetailsTest()
        {
            // TODO: add unit test for the method 'GetFloorDetails'
            int? restaurantId = null; // TODO: replace null with proper value
            string floorId = null; // TODO: replace null with proper value
            
            var response = instance.GetFloorDetails(restaurantId, floorId);
            Assert.IsInstanceOf<Floor> (response, "response is Floor"); 
        }
        
        /// <summary>
        /// Test GetRestaurantFloors
        /// </summary>
        [Test]
        public void GetRestaurantFloorsTest()
        {
            // TODO: add unit test for the method 'GetRestaurantFloors'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetRestaurantFloors(restaurantId);
            Assert.IsInstanceOf<List<FloorInfo>> (response, "response is List<FloorInfo>"); 
        }
        
        /// <summary>
        /// Test GetTableMonitors
        /// </summary>
        [Test]
        public void GetTableMonitorsTest()
        {
            // TODO: add unit test for the method 'GetTableMonitors'
            int? restaurantId = null; // TODO: replace null with proper value
            int? partySize = null; // TODO: replace null with proper value
            DateTimeOffset? time = null; // TODO: replace null with proper value
            
            var response = instance.GetTableMonitors(restaurantId, partySize, time);
            Assert.IsInstanceOf<List<TableMonitor>> (response, "response is List<TableMonitor>"); 
        }
        
        /// <summary>
        /// Test GetTableUsersList
        /// </summary>
        [Test]
        public void GetTableUsersListTest()
        {
            // TODO: add unit test for the method 'GetTableUsersList'
            int? restaurantId = null; // TODO: replace null with proper value
            int? partySize = null; // TODO: replace null with proper value
            DateTimeOffset? time = null; // TODO: replace null with proper value
            
            var response = instance.GetTableUsersList(restaurantId, partySize, time);
            Assert.IsInstanceOf<List<TableUser>> (response, "response is List<TableUser>"); 
        }
        
        /// <summary>
        /// Test GetTables
        /// </summary>
        [Test]
        public void GetTablesTest()
        {
            // TODO: add unit test for the method 'GetTables'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetTables(restaurantId);
            Assert.IsInstanceOf<List<Table>> (response, "response is List<Table>"); 
        }
        
        /// <summary>
        /// Test ReleaseTable
        /// </summary>
        [Test]
        public void ReleaseTableTest()
        {
            // TODO: add unit test for the method 'ReleaseTable'
            int? restaurantId = null; // TODO: replace null with proper value
            string tableNumber = null; // TODO: replace null with proper value
            
            var response = instance.ReleaseTable(restaurantId, tableNumber);
            Assert.IsInstanceOf<TableMonitor> (response, "response is TableMonitor"); 
        }
        
        /// <summary>
        /// Test SeatPartyAtTable
        /// </summary>
        [Test]
        public void SeatPartyAtTableTest()
        {
            // TODO: add unit test for the method 'SeatPartyAtTable'
            int? restaurantId = null; // TODO: replace null with proper value
            string tableNumber = null; // TODO: replace null with proper value
            int? partySize = null; // TODO: replace null with proper value
            
            var response = instance.SeatPartyAtTable(restaurantId, tableNumber, partySize);
            Assert.IsInstanceOf<TableMonitor> (response, "response is TableMonitor"); 
        }
        
        /// <summary>
        /// Test SetApprovedTableCombinations
        /// </summary>
        [Test]
        public void SetApprovedTableCombinationsTest()
        {
            // TODO: add unit test for the method 'SetApprovedTableCombinations'
            int? restaurantId = null; // TODO: replace null with proper value
            List<Table> combinations = null; // TODO: replace null with proper value
            
            instance.SetApprovedTableCombinations(restaurantId, combinations);
             
        }
        
        /// <summary>
        /// Test UpdateFloor
        /// </summary>
        [Test]
        public void UpdateFloorTest()
        {
            // TODO: add unit test for the method 'UpdateFloor'
            int? restaurantId = null; // TODO: replace null with proper value
            string floorId = null; // TODO: replace null with proper value
            Floor floor = null; // TODO: replace null with proper value
            
            var response = instance.UpdateFloor(restaurantId, floorId, floor);
            Assert.IsInstanceOf<Floor> (response, "response is Floor"); 
        }
        
    }

}
