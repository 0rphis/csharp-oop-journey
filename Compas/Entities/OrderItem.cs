using System;
using System.Globalization;

namespace Compas.Entities
{
  class OrderItem
  {
    public int Quantity { get; set; }
    public Product Product { get; private set; }
    public double Price { get; private set; }

    public OrderItem()
    {
    }
    
    public OrderItem(int quantity, Product product, double price)
    {
      Quantity = quantity;
      Product = product;
      Price = price;
    }

    public double SubTotal()
    {
      return Quantity * Price;
    }

    public override string ToString()
    {
      return $"{Product.Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}