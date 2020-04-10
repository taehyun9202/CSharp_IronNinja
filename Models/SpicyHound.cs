using System;
namespace IronNinja.Models
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get
            {
                return calorieIntake >= 1200;
            }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if ( IsFull is false)
            {
                calorieIntake += item.Calories;
                if(item.IsSpicy is true)
                {
                    calorieIntake -= 5;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
                if(calorieIntake > 1200)
                {
                    Console.WriteLine("SpicyTooth is Full and can't take anymore!!!!!!!!!!!!");
                }
            }
        }
    }
}