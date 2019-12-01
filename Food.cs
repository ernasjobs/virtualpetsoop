using System;
namespace virtualpetsoop
{
    public class Food
    {
        public int Amount {get;set;}
        public string Name {get;set;}
        public Food(string name,int benefit)
        {
            Name=name;
            Amount=benefit;
        }
        public void DispayDetails()
        {
            Console.WriteLine($"Name:{Name} Amount:{Amount}");
        }
    }
}