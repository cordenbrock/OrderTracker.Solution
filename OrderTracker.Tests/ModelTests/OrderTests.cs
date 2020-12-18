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
      // Order.ClearAll();
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
      DateTime date = DateTime.Now;
      Order newOrder = new Order(title, description);
      Console.WriteLine(newOrder.Date);
      Console.WriteLine(date);

      Assert.AreEqual(title, newOrder.Title);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(date, newOrder.Date);
    }





  }
}