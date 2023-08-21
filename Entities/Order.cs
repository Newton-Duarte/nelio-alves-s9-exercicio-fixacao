class Order
{
  public DateTime Date { get; set; }
  public OrderStatus Status { get; set; }
  public List<OrderItem> Items { get; set; }
  public Customer Customer { get; set; }

  public override string ToString()
  {
    return $@"
      ORDER SUMMARY:
      Date: {Date}
      Status: {Status}
      Customer: {Customer}
      Order Items:
      {PrintItems()}
    ";
  }

  public string PrintItems()
  {
    var itemsStr = "";
    foreach(var item in Items)
    {
      itemsStr += $"{item}\n";
    }

    return itemsStr;
  }
}