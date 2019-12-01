using System.Collections.Generic;
using System;
namespace virtualpetsoop
{
    public class Inventory
    {
        Menu menu=new Menu();
        User user1=new User("Ernasi",100);
        List<Toy> lstToys=new List<Toy>();
        List<Medicine> lstMedicines=new List<Medicine>();
        List<Food> lstFoods=new List<Food>();
        public void Run()
        {
            Console.Clear();
        }

        public void AddToys(Toy toy)
        {
            lstToys.Add(toy);
        }
        public void AddMedicine(Medicine medicine)
        {
            lstMedicines.Add(medicine);
        }
         public void AddFood(Food food)
        {
            lstFoods.Add(food);;
        }
        public void DisplayToys()
        {
            foreach(Toy toy in lstToys)
            {
                toy.DispayDetails();
            }
            Console.WriteLine();
        }
          public void DisplayFoods()
        {
            foreach(Food food in lstFoods)
            {
                food.DispayDetails();
            }
            Console.WriteLine();
        }
          public void DisplayMedicines()
        {
            foreach(Medicine medicine in lstMedicines)
            {
                medicine.DispayDetails();
            }
            Console.WriteLine();
        }

    }
}