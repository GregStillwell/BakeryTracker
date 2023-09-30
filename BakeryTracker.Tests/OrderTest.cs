using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;


namespace BakeryTracker.Tests
{

  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstancesOfOrder_Order()
    {
      Order newOrder = new Order("title" , "description" , 7, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "new description";
      Order newOrder = new Order(description, "title", 7, "date");
      Assert.AreEqual(description, newOrder.Description);
    }

    [TestMethod]
     public void GetPrice_ReturnsPrice_Int()
    {
      int price = 7;
      Order newOrder = new Order("description", "title",  7, "date");
      Assert.AreEqual(price, newOrder.Price);
    }

    public void GetTitle_ReturnsTitle_String()
    {
      string title = "new title";
      Order newOrder = new Order(title, "description", 9, "date");
      Assert.AreEqual(title, newOrder.Title);
    }
   
  }
}