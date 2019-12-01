using System;
using System.Threading;
namespace virtualpetsoop
{
    public class Simulation1
    {
        private readonly Menu _menu = new Menu();
         Cat cat=new Cat(PetClass.cat,"Billy",100,100);
          Toy ball=new Ball("Ball",3);
          Toy laserPointer=new LaserPointer("Laser Pointer",2);

         public void Run()
         {
             _menu.Run();
             MainMenuOptionSelected();
         }
         public void MainMenuOptionSelected()
         {
              Initialise();
              
              do
              {
                 Update();
                 Display();
                 Thread.Sleep(3000);
              }while(!Console.KeyAvailable);
              var option = Console.ReadKey().KeyChar;
              switch(option)
              {
                  case 'p':
                  Console.Clear();
                  _menu.PlayMenu();
                  do
              {
                 Update();
                 Display();
                 Thread.Sleep(3000);
              }while(!Console.KeyAvailable);
              var input = Console.ReadKey().KeyChar;
                if(input=='1')
                {
                   
                    cat.AmountUpdate=ball.Benifit;
                    Update();
                    Display();
                    Thread.Sleep(3000);
                }
               else if(input=='2')
                {
                    
                    cat.AmountUpdate=laserPointer.Benifit;
                    Update();
                    Display();
                    Thread.Sleep(3000);
                }
                else if(option=='3')
                {
                    _menu.DisplayMainMenu();
                      do
                        {
                            Update();
                            Display();
                            Thread.Sleep(3000);
                        }while(!Console.KeyAvailable);
                     var key = Console.ReadKey().KeyChar;

                }
                  break;
              }
         }
           public void Initialise()
        {
            Console.CursorVisible = false;
            cat.Initialise();
        }
          public void Update()
        {
            cat.Update();    
        }

        public void Display()
        {
            cat.Display();     
        }
    }
}