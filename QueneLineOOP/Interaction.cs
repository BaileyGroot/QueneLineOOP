using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static System.Console;

namespace QueneLineOOP
{
    class Interaction
    {

        private Queue<Guests> guest = new Queue<Guests>();
        public string nameData;
        public int ageData;
        public void Start()
        {
            Title = "Grootrix Nightclub"!;
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string prompt = @"
░██████╗░██████╗░░█████╗░░█████╗░████████╗██████╗░██╗██╗░░██╗
██╔════╝░██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗██║╚██╗██╔╝
██║░░██╗░██████╔╝██║░░██║██║░░██║░░░██║░░░██████╔╝██║░╚███╔╝░
██║░░╚██╗██╔══██╗██║░░██║██║░░██║░░░██║░░░██╔══██╗██║░██╔██╗░
╚██████╔╝██║░░██║╚█████╔╝╚█████╔╝░░░██║░░░██║░░██║██║██╔╝╚██╗
░╚═════╝░╚═╝░░╚═╝░╚════╝░░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝╚═╝░░╚═╝

███╗░░██╗██╗░██████╗░██╗░░██╗████████╗░█████╗░██╗░░░░░██╗░░░██╗██████╗░
████╗░██║██║██╔════╝░██║░░██║╚══██╔══╝██╔══██╗██║░░░░░██║░░░██║██╔══██╗
██╔██╗██║██║██║░░██╗░███████║░░░██║░░░██║░░╚═╝██║░░░░░██║░░░██║██████╦╝
██║╚████║██║██║░░╚██╗██╔══██║░░░██║░░░██║░░██╗██║░░░░░██║░░░██║██╔══██╗
██║░╚███║██║╚██████╔╝██║░░██║░░░██║░░░╚█████╔╝███████╗╚██████╔╝██████╦╝
╚═╝░░╚══╝╚═╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚══════╝░╚═════╝░╚═════╝░ " + "\n";
          

            string[] options = { "1. Add Person", "2. Delete Person", "3. Show list", "4. Show Min/Max", "5. Find a Person", "6. Print all", "7. Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    RunSecondChoice();
                    break;
                case 2:
                    RunThirdChoice();
                    break;
                case 3:
                    RunFourthChoice();
                    break;
                case 4:
                    RunFifthChoice();
                    break;
                case 5:
                    RunSixthChoice();
                    break;
                case 7:
                    ExitMenu();
                    break;
            }
        }
        private void ExitMenu()
        {
            WriteLine("\n Press any key to exit......");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void RunFirstChoice()
        {
            Clear();
            WriteLine("Enter Name: ");
            string name = ReadLine();
            WriteLine("Enter Age: ");
            int age = Convert.ToInt32(ReadLine());

            guest.Enqueue(new Guests() { Name = name, Age = age });
            nameData = name;
            ageData = age;


        }

        private void RunSecondChoice()
        {
            Clear();
            WriteLine("Enter name you want to remove: ");
            string name = ReadLine();

            if (name == nameData)
            {
                guest.Dequeue();
            }
            else
            {
                Write("Couldn't find the person you were looking for.");
            }
        }

        private void RunThirdChoice()
        {
            Clear();
            WriteLine("How many people are on the list: ");
            WriteLine("There is " + guest.Count + " people on the list.");
        }

        private void RunFourthChoice()
        {
            Clear();
            int temp = 0;

            for (int i = 0; i < ageData; i++)
            {
                if (temp < ageData)
                {
                    WriteLine(ageData);
                }
            }
        }
        private int RunFifthChoice()
        {
            Clear();
            string name = ReadLine();
            return Array.IndexOf(guest.ToArray(), name);

        }
        private void RunSixthChoice()
        {
            Clear();

            WriteLine("Print out list: ");
            for (int i = 0; i < guest.Count; i++)
            {
                WriteLine(guest);
            }
        }
    }
}
