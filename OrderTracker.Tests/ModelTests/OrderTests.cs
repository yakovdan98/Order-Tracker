using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {

    [TestMethod]
    public OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Order 1", "Order of 2 breads", 12, "10/23/2022");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
  }
}