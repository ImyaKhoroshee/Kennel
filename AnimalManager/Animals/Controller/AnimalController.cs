using Animals.Entity;
using Animals.Model;
using Animals.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Controller
{
    public class AnimalController
    {
        private AnimalCounter counter;
        private MainView mainView;

        //private int action;

        public AnimalController()
        {
            counter = new AnimalCounter();
            mainView = new MainView();

            //action = 1;
        }

        public void Display()
        {
            while (true)
            {
                try
                {
                    mainView.ShowMenu();
                    string action = Console.ReadLine();

                    switch (action)
                    {
                        case "1":
                            NewAnimal();
                            break;
                        case "2":
                            throw new NotImplementedException("Method not Implemented");
                        case "3":
                            DeleteAnimal();
                            break;
                        case "4": mainView.ShowAnimals(counter.Animals); break;
                        case "9": mainView.ClearScreen(); break;
                        case "0":
                            return;

                        default:
                            mainView.ShowMenu();
                            break;
                    }
                }
                catch (Exception e)
                {
                    mainView.ShowException(e);
                    mainView.PressAnyKey();
                }
            }
        }

        private void DeleteAnimal()
        {
            mainView.EnterValue("Id Animal");
            int id = ReadInt();
            try
            {
                if (counter.DelAnimal(id))
                {
                    mainView.AnimalDeleted(true);
                }
                else
                {
                    mainView.AnimalDeleted(false);
                }
            }
            catch (Exception e)
            {
                mainView.ShowException(e);
            }
            mainView.PressAnyKey();
        }

        private void NewAnimal()
        {
            mainView.EnterValue("Type of Animal (Cat or Dog or Horse or Donkey)");
            string aType = ReadString();

            mainView.EnterValue("Name");
            string name = ReadString();

            mainView.EnterValue("Age");
            int age = ReadInt();

            Animal animal = AnimalCreator.NewAnimal(aType, name, age);
            counter.AddAnimal(animal);

            mainView.AnimalAdded();

        }

        private string ReadString()
        {
            var str = Console.ReadLine();
            while (str == null)
            {
                str = Console.ReadLine();
            }

            return str ?? "";
        }

        private int ReadInt()
        {
            var str = Console.ReadLine();
            int result = 0;
            while (str == null)
            {
                str = Console.ReadLine();
            }
            try
            {
                result = Convert.ToInt32(str);
            }
            catch
            {
                result = 0;
            }
            return result;
        }
    }
}
