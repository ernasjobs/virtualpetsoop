using System;
namespace virtualpetsoop
{
    public class Food
    {
        public int Weight {get;set;}
        public string Name {get;set;}
        public decimal Price{get;set;} 
        public Food(string name,int weight,decimal price)
        {
            Name=name;
            Weight=weight;
            Price=price;
        }
        public void DispayDetails()
        {
            Console.WriteLine($"Name:{Name} Amount:{Weight} Price:{Price}");
        }
    }
}