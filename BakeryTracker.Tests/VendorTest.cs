using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace Vednor.Tests
{
  [TestClass]
  public class ItemVendor : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}