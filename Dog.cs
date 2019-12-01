using System;
namespace virtualpetsoop
{
    public class Dog : VirtualPet,IPlay,IEquipBall
    {
        public IToy iToy=new Ball("Ball",3);
        public Dog(PetClass petClass, string name, int hunger, int mood) : base(petClass, name, hunger, mood)
        {
        }
        public void EquipBall(IToy toy)
        {
            this.iToy=toy;
            
        }

        public void Play(Toy toy)
        {
            Console.WriteLine($"{Name} is playing with {toy.Name} for {iToy.Benifit} benefit");

        }
        
    }
}