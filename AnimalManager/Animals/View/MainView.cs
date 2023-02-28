using Animals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.View
{
    public class MainView
    {
        public MainView() { }

        public void ClearScreen()
        {
            Console.Clear();
        }

        public void ShowMenu() {
            Console.WriteLine("MENU:");
            Console.WriteLine("1: Add new animal");
            Console.WriteLine("2: Find animal by Name");
            Console.WriteLine("3: Delete animal by Id");
            Console.WriteLine("4: Show animal table");
            Console.WriteLine("----------------");
            Console.WriteLine("9: Clear screen");            
            Console.WriteLine("0: Exit");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Enter command:");
        }

        public void ShowAnimal(Animal animal) {
            Console.WriteLine($"ANIMAL PROPERTY:");
            Console.WriteLine($"Name: {animal.Name}");
            Console.WriteLine($"Age: {animal.Age}");
            Console.WriteLine($"AnimalType: {0}", animal.GetType().ToString());

            PressAnyKey();
        }

        public void ShowAnimals(List<Animal> animals)
        {
            Console.WriteLine("ANIMAL LIST:");
            if (animals.Count > 0)
            {

                foreach (Animal animal in animals)
                {
                    Console.WriteLine($"Id: {animal.Id}, Name: {animal.Name}, Age: {animal.Age}, AnimalType: {0}", animal.GetType().ToString());
                }
            }
            else
            {
                Console.WriteLine("Not animals");
            }
            PressAnyKey();
        }

        public void EnterValue(string valueName)
        {
            Console.WriteLine($"Enter a {valueName}");
        }

        public void PressAnyKey()
        {
            Console.WriteLine($"Press any key for continue...\n");
            Console.ReadKey();
        }

        public void AnimalAdded()
        {
            Console.WriteLine("Animal was successfully added");
            PressAnyKey();
        }

        public void ShowException(Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }

        internal void AnimalDeleted(bool v)
        {
            if (v) Console.WriteLine("Animal was successfully deleted");
            else Console.WriteLine("Can`t delete this animal");
        }
    }
}
