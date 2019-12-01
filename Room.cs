using System;
using System.Collections.Generic;
namespace virtualpetsoop
{
    public class Room:IRealTimeComponent
    {
        double startAmbientTemperature;
        double ambientTemperature;
        double startCurrentTemperature;
        double currentTemperature;
         public double AmountUpdate{get;set;}
        public Room(double aTemperature,double cTemperature)
        {   
            startAmbientTemperature=aTemperature;
            startCurrentTemperature=cTemperature;
        }
        
        public void Initialise()
        {
            AmountUpdate=0;
            currentTemperature=startCurrentTemperature;
            ambientTemperature=startAmbientTemperature;
        }

        public void Update()
        {
            currentTemperature+=AmountUpdate;
        }

        public void Display()
        {
           Console.SetCursorPosition(5,10);
           Console.Write("TargetTemp CurrentTemp");
           Console.SetCursorPosition(5,12);
           Console.Write($" {ambientTemperature}      {currentTemperature} ");

        }
    }
}