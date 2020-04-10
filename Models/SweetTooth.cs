using System;
namespace IronNinja.Models
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get
            {
                return calorieIntake >= 1500;
            }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if ( IsFull is false)
            {
                calorieIntake += item.Calories;
                if (item.IsSweet is true)
                {
                    calorieIntake += 10;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
                if(calorieIntake > 1500)
                {
                    Console.WriteLine("SweetTooth is Full and can't take anymore!!!!!!!!!!!");
                }
            }
        }
    }
}
