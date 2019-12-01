using System;
using System.Threading;
using System.Collections.Generic;
namespace virtualpetsoop
{

    public enum AppState
    {
        Running,
        Help,
        Paused,
        Exiting,
        
    }
    
    class Simulation : IRealTimeComponent
    {
        //private bool appRunning = true;
        AppState appState = AppState.Running;
        private readonly Menu menu=new Menu();
      //   public List<VirtualPet> Pets = new List<VirtualPet>();
          Cat cat=new Cat(PetClass.cat,"Billy",50,50);
          Room room=new Room(22.82,20.90);
        //  Dog dog=new Dog(PetClass.dog,"Molly",3,3);
         Ball ball=new Ball("Ball",3);
         Toy laserPointer=new LaserPointer("Laser Pointer",2);
         int menuIndex=0;
        public Simulation()
        {
            
        }
        public void Run()
        {  
            
            Initialise();
            
            
            do
            {
            
                switch(menuIndex)
                {
                    case 0:
                    Console.Clear();
                    Console.SetCursorPosition(5,1);
                    Console.WriteLine("Welcome to Virtual Pets App.");
                    Console.SetCursorPosition(10,3);
                    Console.WriteLine("====Room 1====");
                    menu.DisplayMainMenu();
                    break;
                    case 1:
                    Console.Clear();
                    Console.SetCursorPosition(5,1);
                    Console.WriteLine("Welcome to Virtual Pets App.");
                    Console.SetCursorPosition(10,3);
                    Console.WriteLine("====Room 1====");
                    menu.PlayMenu();
                    Display();
                    break;
                    case 2:
                    Console.Clear();
                    Console.SetCursorPosition(5,1);
                    Console.WriteLine("Welcome to Virtual Pets App.");
                    Console.SetCursorPosition(10,3);
                    Console.WriteLine("====Room 1====");
                    menu.ControlTempMenu();
                    Display();
                    break;

                }
            
                CheckKeyInput();

                switch (appState)
                {
                    case AppState.Running:
                        Update();
                        Display();
                        break;
                    case AppState.Paused:
                        break;
                    default:
                        break;
                }
                Thread.Sleep(2000);
            } while (appState != AppState.Exiting);
        }
        public void Initialise()
        {
            Console.CursorVisible = false;
            cat.Initialise();
            room.Initialise();
        }
          public void Update()
        {
            cat.Update();
            room.Update();
            
        }
        public void Display()
        {
          //  Console.Clear();
            cat.Display();
            room.Display();
            
        }
       
        public void CheckKeyInput()
        {
            
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                 if (keyPressed == ConsoleKey.P)
                {  
                    if (appState != AppState.Paused)
                    {
                        menuIndex=1;
                        appState = AppState.Paused;
                        
                    }
                    else if (appState == AppState.Paused)
                    {
                        menuIndex=0;
                        appState = AppState.Running;
                    }

                }
                if(keyPressed==ConsoleKey.C)
                {
                     if (appState != AppState.Paused)
                    {
                        menuIndex=2;
                        appState = AppState.Paused;
                        
                    }
                    else if (appState == AppState.Paused)
                    {
                        menuIndex=0;
                        appState = AppState.Running;
                    }
                }

                if(keyPressed==ConsoleKey.B)
                {
                    ball.Uses--;
                    if(ball.Uses>0)
                    {
                    cat.AmountUpdate=-ball.Benifit;
                    cat.Play(ball);
                    Update();
                    Display();
                    Thread.Sleep(5000);
                    cat.AmountUpdate=1;
                    appState=AppState.Running;
                    }
                    else
                    {
                        Console.WriteLine("You need to buy a new ball");
                    }
                  
                }
                 if(keyPressed==ConsoleKey.UpArrow)
                {   
                    room.AmountUpdate=0.01;
                    Update();
                    Display();
                    Thread.Sleep(3000);
                    appState=AppState.Running;
                }
                if(keyPressed==ConsoleKey.DownArrow)
                {   
                    room.AmountUpdate=-0.01;
                    Update();
                    Display();
                    Thread.Sleep(3000);
                    appState=AppState.Running;
                }
                
                 if(keyPressed==ConsoleKey.L)
                {
                    cat.AmountUpdate=-laserPointer.Benifit;
                    cat.Play(laserPointer);
                    Update();
                    Display();
                    Thread.Sleep(5000);
                    cat.AmountUpdate=1;
                    appState=AppState.Running;
                }
                 if(keyPressed==ConsoleKey.M)
                {
                    menuIndex=0;
                }
                if (keyPressed == ConsoleKey.Escape)
                {
                    appState = AppState.Exiting;
                }

                if (keyPressed == ConsoleKey.F)
                {
                    Console.SetCursorPosition(5,10);
                    Console.WriteLine("You just feed Billy");
                }
               

                if (keyPressed == ConsoleKey.R)
                {
                    cat.Initialise();
                }

                if (keyPressed == ConsoleKey.T)
                {
                    Console.SetCursorPosition(5,10);
                    Console.WriteLine("You just tend with Billy");
                }
                if (keyPressed == ConsoleKey.S)
                {
                    Console.SetCursorPosition(5,10);
                    Console.WriteLine("Go to shop");
                } 
               
            }
           
        }

      
    }
}
