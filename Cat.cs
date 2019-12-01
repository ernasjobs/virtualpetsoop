using System;
namespace virtualpetsoop
{
    public class Cat : VirtualPet,IPlay,IEquipBall
    {
        public IToy iToy=new Ball("Ball",3);
        
        public Cat(PetClass petClass, string name, int hunger, int mood) : base(petClass, name, hunger, mood)
        {
        }
        public void EquipBall(IToy toy)
        {
            this.iToy=toy;
            
        }

        public void Play(Toy toy)
        {
           Console.SetCursorPosition(5,9);
           Console.Beep();
           Console.Write($"{Name}  played with {toy.Name}");
           Console.SetCursorPosition(5,10);
           Console.Write($"Toy Benefit {toy.Benifit}");
        }
        
    }
}