using System;
namespace virtualpetsoop
{
    public class Menu
    {
        public void Run()
        {
         DisplayMainMenu();
        }
        public void DisplayMainMenu()
        {
            Console.CursorVisible = false;
            string[] menuOptions =
                {"F-Feed", "P-Play","T-Tend","S-Shop","C-Control Temp"};
            Draw(40, 8, "Main Menu");
            //  Draw(8, 0, "Select Floor");
            Draw(37, 10, "██████████████████", ConsoleColor.Red);

            for (var i = 11; i < 18; i++)
            {
                Draw(37, i, "█", ConsoleColor.Red);
                Draw(54, i, "█", ConsoleColor.Red);
            }

            Draw(37, 18, "██████████████████", ConsoleColor.Red);

            for (var i = 0; i < menuOptions.Length; i++) Draw(39, 12 + i, menuOptions[i]);
        }
         public void PlayMenu()
        {
            Console.CursorVisible = false;
            string[] menuOptions =
                {"B-Ball", "L-Laser Pointer","M-Main Menu"};
            Draw(40, 8, "Play Menu");
            //  Draw(8, 0, "Select Floor");
            Draw(37, 10, "██████████████████", ConsoleColor.Red);

            for (var i = 11; i < 17; i++)
            {
                Draw(37, i, "█", ConsoleColor.Red);
                Draw(54, i, "█", ConsoleColor.Red);
            }

            Draw(37, 17, "██████████████████", ConsoleColor.Red);

            for (var i = 0; i < menuOptions.Length; i++) Draw(39, 12 + i, menuOptions[i]);
        }
         public void ControlTempMenu()
        {
            Console.CursorVisible = false;
            string[] menuOptions =
                {"+) Warm", "-)Cool","M-Main Menu"};
            Draw(40, 8, "Control Temp");
            //  Draw(8, 0, "Select Floor");
            Draw(37, 10, "██████████████████", ConsoleColor.Red);

            for (var i = 11; i < 17; i++)
            {
                Draw(37, i, "█", ConsoleColor.Red);
                Draw(54, i, "█", ConsoleColor.Red);
            }

            Draw(37, 17, "██████████████████", ConsoleColor.Red);

            for (var i = 0; i < menuOptions.Length; i++) Draw(39, 12 + i, menuOptions[i]);
        }
         public void ShopMenu()
        {
            Console.CursorVisible = false;
            string[] menuOptions =
                {"1-) Food", "2-)Medicine","3-)Toys"};
            Draw(40, 8, "Control Temp");
            //  Draw(8, 0, "Select Floor");
            Draw(37, 10, "██████████████████", ConsoleColor.Red);

            for (var i = 11; i < 17; i++)
            {
                Draw(37, i, "█", ConsoleColor.Red);
                Draw(54, i, "█", ConsoleColor.Red);
            }

            Draw(37, 17, "██████████████████", ConsoleColor.Red);

            for (var i = 0; i < menuOptions.Length; i++) Draw(39, 12 + i, menuOptions[i]);
        }
        public void Draw(int left, int top, string outputString)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(outputString);
        }
        // places the cursor position to the certain point in the screen and changes ForegroundColor property to Grey
        public void Draw(int left, int top, string outputString, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(left, top);
            Console.Write(outputString);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}