using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description)
    {
      Title = title;
      Description = description;
    }
  }
}