using System.Collections.Generic;

namespace ForSale.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Contact { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string name, string description, string contact)
    {
      Name = name;
      Description = description;
      Contact = contact;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}