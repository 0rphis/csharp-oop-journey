using System;
using System.Globalization;
using Compas.Entities;
using Compas.Entities.Enums;

namespace Compas
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter client data:");
      Console.Write("Name: ");
      string name = Console.ReadLine();
      Console.Write("Email: ");
      string email = Console.ReadLine();
      Console.Write("Birth date (DD/MM/YYYY): ");
      DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
      Console.WriteLine();

      Console.WriteLine("Enter order data:");

      Client client = new Client(name, email, birthDate);
      Console.Write("Status: ");
      OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
      Order order = new Order(status, client);
      Console.WriteLine();




      Console.Write("How many items to this order? ");
      int n = int.Parse(Console.ReadLine());
      for (int i = 1; i <=n; i++)
      {
        Console.WriteLine("Enter #" + i + " item data:");
        Console.Write("Product name: ");
        string productName = Console.ReadLine();
        Console.Write("Product price: ");
        double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Product product = new Product(productName, productPrice);
        OrderItem orderItem = new OrderItem(quantity, product, productPrice);
        order.AddItem(orderItem);
      }

      Console.WriteLine(order);
    }
  }
}