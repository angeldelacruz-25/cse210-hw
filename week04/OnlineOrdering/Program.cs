
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Address address2 = new Address(
            "45 Central Avenue",
            "Santo Domingo",
            "Distrito Nacional",
            "Dominican Republic"
        );

        // Create customers
        Customer customer1 = new Customer("Angel De La Cruz", address1);
        Customer customer2 = new Customer("Flor Celeste", address2);

        // Create products
        Product product1 = new Product("Laptop", "P001", 800.00, 1);
        Product product2 = new Product("Mouse", "P002", 25.00, 2);
        Product product3 = new Product("Keyboard", "P003", 50.00, 1);

        Product product4 = new Product("Monitor", "P004", 200.00, 1);
        Product product5 = new Product("Headphones", "P005", 75.00, 2);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Store orders in a list
        List<Order> orders = new List<Order>
        {
            order1,
            order2
        };

        // Display order information
        foreach (Order order in orders)
        {
            Console.WriteLine("============================");
            Console.WriteLine(order.GetOrderInfo());

            Console.WriteLine();
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine("============================\n");
        }
    }
}
