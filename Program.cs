using System;
using PetStore;
using System.Collections.Generic;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<CatFood>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                var catFood = new CatFood();

                Console.WriteLine("Enter the Name: ");
                catFood.ProductName = Console.ReadLine();

                Console.WriteLine("Enter the Price: ");
                catFood.ProductPrice = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Brand: ");
                catFood.Brand = Console.ReadLine();

                Console.WriteLine("Is it for kittens? (true/false): ");
                catFood.KittenFood = bool.Parse(Console.ReadLine());

                recordList.Add(catFood);
            }

            Console.WriteLine("The records you entered are:");
            foreach (var record in recordList)
            {
                Console.WriteLine(record.ToString());
            }
        }
    }
}