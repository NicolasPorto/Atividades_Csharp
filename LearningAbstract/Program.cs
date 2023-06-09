﻿using LearningAbstract.Entities;
using LearningAbstract.Entities.Enum;
using System.Globalization;

namespace LearningAbstract
{
    class Program
    {
        public static void Main(String[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("Shape #" + i + " data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));

                }
                if(ch == 'c')
                {

                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));

                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");

            foreach(Shape ar in list)
            {
                Console.WriteLine(ar.Area().ToString("F2", CultureInfo.InvariantCulture));

            }

        }
    }
}