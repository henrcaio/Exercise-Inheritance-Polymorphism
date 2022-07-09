using System;
using Exercise_Inheritance_Polymorphism.Entities;
using System.Collections.Generic;

namespace Exercise_Inheritance_Polymorphism {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Regular, used or imported (R/U/I)? ");
                string type = Console.ReadLine();
                if (type.ToUpper() == "U") {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacturing date: ");
                    DateTime manufacturingDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufacturingDate));
                }
                else if(type.ToUpper() == "I") {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customs));
                }
                else {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    list.Add(new Product(name, price));
                }
            }
            
            foreach (Product item in list) {
                Console.WriteLine(item.PriceTag());

            }

        }
    }
}
