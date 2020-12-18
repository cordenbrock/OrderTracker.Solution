using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "name";
      string description = "description";

      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void TestProps_RetrievesObjProperties_Props()
    {
      string name = "name";
      string description = "description";

      Vendor newVendor = new Vendor(name, description);

      Assert.AreEqual(name, newVendor.Name);
      Assert.AreEqual(description, newVendor.Description);
    }

    [TestMethod]
    public void GetAll_ReturnsVendorList_VendorList()
    {
      Vendor newVendor1 = new Vendor("test1", "test1");
      Vendor newVendor2 = new Vendor("test2", "test2");
      Vendor newVendor3 = new Vendor("test3", "test3");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2, newVendor3 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
      Vendor newVendor = new Vendor("title", "description");

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

        [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("title1", "description1");
      Vendor newVendor2 = new Vendor("title2", "description2");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

        [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("title", "description");
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor("name", "description");
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}