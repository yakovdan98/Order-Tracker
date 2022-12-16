using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    private int createdId = 0;
    public int Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Id = ++createdId;
      Orders = new List<Order>{};
      _instances.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int Id)
    {
      foreach (Vendor item in _instances)
      {
        if(item.Id == Id) {return item;}
      }
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}

//properties
//id
//name
//description
//List<orders>
//Find
//GetAll
//AddOrder