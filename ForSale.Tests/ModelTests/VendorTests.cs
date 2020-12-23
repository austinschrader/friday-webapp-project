using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForSale.Models;

namespace ForSale.Tests
{
  [TestClass]
  public class VendorTest
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_VendorTitle()
    {
      Vendor newVendor = new Vendor("Marie's Cafe", "Marie started her bakery in 1950.");
      string myVendor = "Marie's Cafe";
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      Assert.AreEqual(myVendor, newVendor.Name);
    }
  }
}