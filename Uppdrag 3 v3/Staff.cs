﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Uppdrag_3_v3
{

    public class Staff
    {
        public string Name { get; set; }

        List<string> staff = new List<string>() { "Henrik", "Patrik", "Karl", "Pernilla" };
        public Staff(string name)
        {

            Name = name;

        }
        public void Manage() //Hanterar bilar
        {
            Console.WriteLine("Welcome, here you can see the staff available");

            foreach (string i in staff)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("What would you like to do?\n");

            Console.WriteLine("1. Hire Employee");
            Console.WriteLine("2. Kick Employee ");
            Console.WriteLine("3. Return to Main Menu");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter name of employee to hire.");
                    string employeeToHire = Console.ReadLine();
                    Add(employeeToHire);
                    break;
                case "2":
                    Console.WriteLine("Write the employee you want to kick.");
                    string employeeToKick = Console.ReadLine();
                    Kick(employeeToKick);
                    break;
                case "3":
                    Console.WriteLine("Returning...");
                    break;



            }
            void Add(string name)
            {
                staff.Add(name);
            }

            void Kick(string name)
            {                
                staff.RemoveAll(x => x == name); //Ta bort anställd som har namnet användaren valt att skriva in 
            }

        }

    }
}
