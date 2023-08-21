System.Console.WriteLine("Enter Customer data:");
System.Console.WriteLine("--------------------");
System.Console.Write("Name: ");
var customerName = Console.ReadLine();
System.Console.Write("E-mail: ");
var customerEmail = Console.ReadLine();
System.Console.Write("Birth date: ");
var customerBirthDate = Console.ReadLine();

var orderCustomer = new Customer {
  Name = customerName,
  Email = customerEmail,
  BirthDate = customerBirthDate
};

System.Console.WriteLine("Enter Order data:");
System.Console.WriteLine("--------------------");
System.Console.Write("How many items to this order? ");
int itemsCount = int.Parse(Console.ReadLine());

int counter = 1;
List<OrderItem> orderItems = new();
while (counter <= itemsCount)
{
  System.Console.WriteLine($"Enter #{counter} item data:");
  System.Console.WriteLine("--------------------");
  System.Console.Write("Product name: ");
  var productName = Console.ReadLine();
  System.Console.Write("Product price: ");
  var productPrice = double.Parse(Console.ReadLine());
  System.Console.Write("Product quantity: ");
  var productQuantity = int.Parse(Console.ReadLine());

  var product = new Product {
    Name = productName,
    Price = productPrice
  };

  var orderItem = new OrderItem {
    Product = product,
    Price = productPrice,
    Quantity = productQuantity,
  };

  orderItems.Add(orderItem);

  counter++;
}

var order = new Order {
  Date = DateTime.Now,
  Customer = orderCustomer,
  Items = orderItems,
  Status = OrderStatus.Pending,
};

System.Console.WriteLine(order);