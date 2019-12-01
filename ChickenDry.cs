using System;
namespace virtualpetsoop
{
    public class ChickenDry : Food
    {
        public int Benifit {get;set;}
        public ChickenDry(string name, int weight, decimal price,int benifit) : base(name, weight, price)
        {
            Benifit=benifit;
        }
    }
}