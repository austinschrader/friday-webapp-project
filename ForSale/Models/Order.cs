using System.Collections.Generic;

namespace ForSale.Models
{
  public class Orders
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Orders> _instances = new List<Orders> { };

    public Orders(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

  }
}