using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string serialNumber = input[0];
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                decimal itemPrice = decimal.Parse(input[3]);

                boxes.Add(new Box(serialNumber, itemName, itemQuantity, itemPrice));

                command = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(boxes => boxes.Price).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box(string serialNumber, string itemName, int itemQuantity, decimal itemPrice)
        {
            SerialNumber = serialNumber;
            ItemQuantity = itemQuantity;
            Item.Name = itemName;
            Item.Price = itemPrice;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set;  } = new Item();
        public int ItemQuantity { get; set; }
        public decimal Price 
        { 
            get
            {
                return ItemQuantity * Item.Price;
            }
        }
    }
}
