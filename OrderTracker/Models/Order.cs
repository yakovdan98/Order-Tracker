
namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Date { get; set; }


    public Order(string title, string description, double price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}
//properties
//Title
//description
//price
//date
