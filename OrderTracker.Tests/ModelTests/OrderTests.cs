using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System;
using System.Collections.Generic;


namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "title";
      string description = "description";

      Order newOrder = new Order(title, description);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void TestProps_RetrievesObjProperties_Props()
    {
      string title = "title of immense profundity";
      string description = "descriptive words of a descriptive nature";
      DateTime date = (DateTime.Now).Date;

      Order newOrder = new Order(title, description);

      Assert.AreEqual(title, newOrder.Title);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(date, newOrder.Date);
    }

    [TestMethod]
    public void GetAll_ReturnsOrderList_OrderList()
    {
      Order newOrder1 = new Order("test1", "test1");
      Order newOrder2 = new Order("test2", "test2");
      Order newOrder3 = new Order("test3", "test3");
      List<Order> newList = new List<Order> { newOrder1, newOrder2, newOrder3 };

      List<Order> result = Order.GetAll();
      
      CollectionAssert.AreEqual(newList, result);
    }



  }
}