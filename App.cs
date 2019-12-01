using System;
using System.Threading;
namespace virtualpetsoop
{
       public class App:IRealTimeComponent
    {
        private readonly Menu _menu=new Menu();
        Cat cat=new Cat(PetClass.cat,"Billy",5,5);
       // Toy ball=new Ball("Ball",3);
        public void Run()
        {
            //_menu.Run();
            Initialise();
            MenuOptionSelected();

        }
        public void MenuOptionSelected()
        {
          //  _menu.DisplayMainMenu();
            var option = Console.ReadKey().KeyChar;
            
                do
                {
                    Update();
                    Display();
                    Thread.Sleep(2000);
                } while (!Console.KeyAvailable);
            
        }
        public void Initialise()
        {
            Console.CursorVisible = false;
            Console.Clear();
            cat.Initialise();
        }
          public void Update()
        {
            cat.Update();             
        }

        public void Display()
        {
            Console.Clear();
            
              cat.Display();
            
            
        }
    }
}