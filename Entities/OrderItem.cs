class OrderItem
{
  public int Quantity { get; set; }
  public double Price { get; set; }
  public Product Product { get; set; }

  public string Subtotal()
  {
    return (Quantity * Price).ToString();
  }

  public override string ToString()
  {
    return $"{Product.Name}, {Product.Price:F2}, Quantity: {Quantity:F2}, Subtotal: {Subtotal():F2}";
  }
}