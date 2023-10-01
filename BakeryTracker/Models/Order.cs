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
    private static int _idCounter = 0;
    public static List<Order> _instances = new List<Order> {};
    public int Id { get; }
    public Order(string description, int price, string title, string date)
    
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
       _idCounter++;
    }

     public static void ClearAll()
    {
      _instances.Clear();
       _idCounter = 0;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}