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

    public static List<Orders> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Orders Find(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}