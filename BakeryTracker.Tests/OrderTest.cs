using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;


namespace BakeryTracker.Tests
{

  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstancesOfOrder_Order()
    {
      Order newOrder = new Order("description" , 7 , "title", "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "new description";
      Order newOrder = new Order(description, 7, "title", "date");
      Assert.AreEqual(description, newOrder.Description);
    }

    [TestMethod]
     public void GetPrice_ReturnsPrice_Int()
    {
      int price = 7;
      Order newOrder = new Order("description", 7,  "title", "date");
      Assert.AreEqual(price, newOrder.Price);
    }

     [TestMethod]
     public void GetTitle_ReturnsTitle_String()
     {
       string title = "new title";
       Order newOrder = new Order("description", 7, title, "date");
       Assert.AreEqual(title, newOrder.Title);
     }
     [TestMethod]
      public void GetDate_ReturnsDate_Date()
    {
      string date = ("2020, 7,1");
      Order newOrder = new Order("description",7 ,"title" , date);
      Assert.AreEqual(date, newOrder.Date);
    }
      [TestMethod]
      public void GetId_ReturnsId_Int()
    {
      Order newOrder = new Order("description", 7, "title", "date");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

  }
}