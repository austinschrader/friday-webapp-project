using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForSale;

namespace ForSale.Tests
{
  [TestClass]
  public class OrderTest
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("pastries");
      string myOrder = "pastries";
      Assert.AreEqual(typeof(Order), newOrder.GetType());
      Assert.AreEqual(myOrder, newOrder.Description);
    }
  }
}