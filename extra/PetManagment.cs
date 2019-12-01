using System.Collections.Generic;
using System;
namespace virtualpetsoop
{
    public class PetManagment
    {
         public List<VirtualPet> Pets = new List<VirtualPet>();

        public void AddPet(VirtualPet pet)
        {
            Pets.Add(pet);
        }

        public void DisplayPets()
        {
            foreach(VirtualPet pet in Pets)
            {
             pet.Display();
            }
            Console.WriteLine();
        }

    }
}