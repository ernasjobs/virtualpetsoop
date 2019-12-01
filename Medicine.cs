using System;
namespace virtualpetsoop
{
    public class Medicine
    {
          public int Benifit {get;set;}
        public string Name {get;set;}
        public Medicine(string name,int benefit)
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