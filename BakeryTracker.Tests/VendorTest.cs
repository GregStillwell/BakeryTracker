using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("a great vendor", "Greg");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

     [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "a great vendor";
      string name = "Greg";
      Vendor newVendor = new Vendor(description, name);
      Assert.AreEqual(description, newVendor.Description);
    }


  }
}