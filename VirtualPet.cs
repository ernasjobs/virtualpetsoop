using System;
namespace virtualpetsoop
{
    public class VirtualPet:RealTimeComponent
    {
        private readonly PetClass petClass;
        public string Name {get;set;}
        int  startHunger;
        int hunger;
        int startMood;
        int mood;
        public int Health {get;set;}
        public int AmountUpdate{get;set;}
        bool active =true;
        public VirtualPet(PetClass petClass,string name,int hunger,int mood)
        {
            this.petClass=petClass;
            Name=name;
            startHunger=hunger;
            startMood=mood;
            Health=5;
        }
         public void Initialise()
        {
            AmountUpdate=1;
            hunger=startHunger;   
            mood=startMood;

        }

        public void Update()
        {
            if(mood>0 && hunger>0)
            {
                mood-=AmountUpdate;
                hunger+=AmountUpdate;
            }

        }

        public void Display()
        {
            if (active)
            {
                Console.SetCursorPosition(5, 4);
                Console.Write(AmountUpdate);
                Console.SetCursorPosition(6, 4);
                Console.Write(hunger);
                Console.SetCursorPosition(7,4);
                Console.Write(mood);
            }
        }
        public virtual void DisplayPetInfo()
        {
            Console.Write("\n\tYour " + petClass + ", " + Name +"\n\n");
            Console.WriteLine("\n");
        } 
    }
}