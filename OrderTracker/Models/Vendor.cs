using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    private static int createdId = 0;
    public int Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      createdId++;
      Id = createdId;
      Orders = new List<Order> { };
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
        if (item.Id == Id)
        {
          return item;
        }
      }
      return null;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static void Clear()
    {
      _instances.Clear();
      createdId = 0;
    }

    public static void Delete(int id)
    {
      for (int i = 0; i < _instances.Count; i++)
      {
        if (_instances[i].Id == id)
        {
          _instances.RemoveAt(i);
        }
      }
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