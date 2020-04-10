using System;
using System.Collections.Generic;
namespace IronNinja.Models
{
    public class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food ("Shrimp Pasta", 800 , true, false),
                new Food ("Hamburger", 1000, false, false),
                new Food ("Chili Nacho", 500, true, true),
                new Food ("Cupcake", 600, false, true),
                new Food ("Chipotle", 1200, true, true),
                new Drink ("Cholula", 100, true, false),
                new Drink ("Sriracha", 100, true, false),
                new Drink ("Coffee", 200, false, false),
                new Drink ("Strawberry Smoothie", 400, false, true),
                new Drink ("Orange Juice", 400, false, true),
            };
        }
        public IConsumable Serve()
        {
            Random ranItem = new Random();
            IConsumable item = Menu[ranItem.Next(Menu.Count)];
            Console.WriteLine($"Selection: {item.Name}\n Calories: {item.Calories}\n Spicy:{item.IsSpicy}\n Sweet:{item.IsSweet}");
            return item;
        }
    }
}
