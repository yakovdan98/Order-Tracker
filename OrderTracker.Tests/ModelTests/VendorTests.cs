using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.Clear();
    }
    [TestMethod]
    public VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("suzie cafe", "cafe near 140th st");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public AddOrders_AddsAnOrderToVendor_AddOrder()
    {
      Vendor newVendor = new Vendor("suzie cafe", "cafe near 140th st");
      Order newOrder = new Order("Order 1", "Order of 2 breads", 12, "10/23/2022");
      List<Order> newList = new List<Order> {newOrder};
      newVendor.AddOrder(newOrder);
      CollectionsAssert.AreEqual(newList, newVendor.Orders);
    }

    [TestMethod]
    public GetAll_ReturnsAllVendors_Vendors()
    {
      
      Vendor newVendor = new Vendor("suzie cafe", "cafe near 140th st");
      Vendor newVendor2 = new Vendor("1st st cafe", "1st st");
      List<Vendor> newList = new List<Vendor> {newVendor, newVendor2};
      CollectionsAssert.AreEqual(newList, Vendor.GetAll());
    }

    [TestMethod]
    public FindVendor_FindsVendorByID_Vendor()
    {
      Vendor newVendor = new Vendor("suzie cafe", "cafe near 140th st");
      Assert.AreEqual("suzie cafe", Vendor.Find(1).Name);
    }
  }
}