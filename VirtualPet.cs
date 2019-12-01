using System;
using System.Threading;
namespace virtualpetsoop
{
    public class VirtualPet:IRealTimeComponent
    {
        public  PetClass petClass;
        public string Name {get;set;}
        int  startHunger;
        int hunger;
        int startMood;
        int startHealth;
        int health;
        public int Mood
        {
            get{return startMood;}
            set {startMood=value;}
        }
         public int Hunger
        {
            get{return startHunger;}
            set {startHunger=value;}
        }
        public int Health
        {
            get{return startHealth;}
            set{startHealth=value;}
        }
        int mood;
       
        public int AmountUpdate{get;set;}
        public VirtualPet(PetClass petClass,string name,int hunger,int mood)
        {
            this.petClass=petClass;
            Name=name;
            startHunger=hunger;
            startMood=mood;
            startHealth=50;
        }
         public  void Initialise()
        {
            AmountUpdate=1;
            hunger=startHunger;   
            mood=startMood;
            health=startHealth;
        }

        public  void Update()
        {
            if(mood>0)
            {
                mood-=AmountUpdate;
                
            }
            if(hunger>0)
            {
                if(hunger >70)
                { 
                     health-=AmountUpdate;
                     hunger+=AmountUpdate;
                     if(health<0)
                     health=0;
                }
                hunger+=AmountUpdate;
            }

        }
        public void Display()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(5,5);
            Console.WriteLine($" Name Type Mood Hunger Health");
            Console.SetCursorPosition(5,7);
            Console.WriteLine($" {Name} {petClass}  {mood}   {hunger}     {health}");
        }
    }
}