using System;

class Program
{
    static void Main(string[] args)
    {
        Address customerAddress = new Address("88 W 200 N", "ShaTin", "NT", "HK");

        Customer customerA = new Customer("Mary Ann", customerAddress);

        Product p1 = new Product("Product1", "1001", 10, 1);
        Product p2 = new Product("Product2", "1002", 15, 2);

        Order o1 = new Order(customerA);
        o1.AddProduct(p1);
        o1.AddProduct(p2);

        Address customerAddressB = new Address("123 W 456 N", "Orem", "UT", "USA");

        Customer customerB = new Customer("John Hansen", customerAddressB);

        Product p3 = new Product("Product3", "1003", 20, 1);
        Product p4 = new Product("Product4", "1004", 25, 2);

        Order o2 = new Order(customerB);
        o2.AddProduct(p3);
        o2.AddProduct(p4);

        Console.WriteLine("Order 1:");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Price: ${o1.CalculateTotalPrice()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Price: ${o2.CalculateTotalPrice()}\n");



    }
}