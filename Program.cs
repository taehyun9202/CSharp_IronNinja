using System;
using IronNinja.Models;
namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            // foreach(var item in buffet.Menu)
            // {
            //     Console.WriteLine($"{item.Name}: {item.Calories} Calories");
            // }
            SweetTooth SweetNinja = new SweetTooth();
            SpiceHound SpicyNinja = new SpiceHound();
            while(SweetNinja.IsFull == false)
            {
                SweetNinja.Consume(buffet.Serve());
                // foreach(var item in SweetNinja.ConsumptionHistory)
                // {
                //     Console.WriteLine($"Sweet ninja Just had {item.Name} calories of {item.Calories}.");
                // }
            }
            Console.WriteLine($"Sweet ninja had total {SweetNinja.ConsumptionHistory.Count} food!!!");
            while(SpicyNinja.IsFull == false)
            {
                SpicyNinja.Consume(buffet.Serve());
                Console.WriteLine(SpicyNinja.ConsumptionHistory.Count);
            }
            Console.WriteLine($"Spicy ninja had total {SpicyNinja.ConsumptionHistory.Count} food!!!");
        }
    }
}
