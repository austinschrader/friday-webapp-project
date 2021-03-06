using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForSale.Models;

namespace ForSale.Tests
{
  [TestClass]
  public class OrderTest
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_OrderTitle()
    {
      Order newOrder = new Order("Order One", "Pastries order", 50, "12/22/2020");
      string myOrder = "Order One";
      Assert.AreEqual(typeof(Order), newOrder.GetType());
      Assert.AreEqual(myOrder, newOrder.Title);
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_OrderDescription()
    {
      Order newOrder = new Order("Order One", "Pastries order", 50, "12/22/2020");
      string myOrder = "Pastries order";
      Assert.AreEqual(typeof(Order), newOrder.GetType());
      Assert.AreEqual(myOrder, newOrder.Description);
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_OrderPrice()
    {
      Order newOrder = new Order("Order One", "Pastries order", 50, "12/22/2020");
      int myOrder = 50;
      Assert.AreEqual(typeof(Order), newOrder.GetType());
      Assert.AreEqual(myOrder, newOrder.Price);
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_OrderDate()
    {
      Order newOrder = new Order("Order One", "Pastries order", 50, "12/22/2020");
      string myOrder = "12/22/2020";
      Assert.AreEqual(typeof(Order), newOrder.GetType());
      Assert.AreEqual(myOrder, newOrder.Date);
    }

  }
}