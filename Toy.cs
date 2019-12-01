using System;
namespace virtualpetsoop
{
    public class Toy:IToy
    {
        public int Benifit {get;set;}
        public string Name {get;set;}
        public Toy(string name,int benefit)
        {
            Name=name;
            Benifit=benefit;
        }
        public void DispayDetails()
        {
            Console.WriteLine($"Name:{Name} Benefit:{Benifit}");
        }
    }
}