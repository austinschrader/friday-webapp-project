using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ForSale.Models;
using System;

namespace Vendor.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      ForSale.ClearAll();
    }

    [TestMethod]
    public void ForSaleConstructor_CreatesInstanceOfVendor_Vendor()
    {

    }
  }
}