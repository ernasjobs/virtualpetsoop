using System;
namespace virtualpetsoop
{
    public class Medicine
    {
        
        public int Benifit {get;set;}
        public string Name {get;set;}
        public int NumOfShots{get;set;}
        public Medicine(string name,int benefit,int numOfShots)
        {
            Name=name;
            Benifit=benefit;
            NumOfShots=numOfShots;
        }
        public void DispayDetails()
        {
            Console.WriteLine($"Name:{Name} Benefit:{Benifit}");
        }
        
    }
}