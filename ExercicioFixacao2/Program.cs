﻿using ExercicioFixacao2.Entities;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(String[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {

                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'u')
                {

                    Console.Write("Manufacture date (DD/MM/YYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));   

                }
                if(ch == 'i')
                {

                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, fee));

                }
                if (ch == 'c')
                {

                    list.Add(new Product(name, price));

                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product prod in list)
            {

                Console.WriteLine(prod.priceTag());

            }
        }
    }
}