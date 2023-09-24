using System;
using System.Collections.Generic;

namespace BakeryTracker.Models
{

  public class Order
  {
    public string Description {get; set;  }
    public string Title { get; set; }
    public int Price {get; set;  }
    public string Date {get; set; }
    public static List<Order> _instances = new List<Order> {};
    public int Id { get; }
    public Order(string description, string title, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

     public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}