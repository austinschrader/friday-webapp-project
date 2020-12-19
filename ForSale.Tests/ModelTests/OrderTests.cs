using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ForSale.Models;
using System;

namespace Order.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      ForSale.ClearAll();
    }

    [TestMethod]
    public void ForSaleConstructor_CreatesInstanceOfOrder_Order()
    {

    }
  }
}