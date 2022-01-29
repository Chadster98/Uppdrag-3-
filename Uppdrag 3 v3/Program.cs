using System;
using System.Collections.Generic;


namespace Uppdrag_3_v3
{
    public class Program
    {

         static void Main()
        {

            Menu();
        }
        public static void Menu()
        {
            Car car = new Car();
            Buyer buyer = new Buyer();

            string[] menuoptions = new string[] { "1. Register buyer of car ", "2. Manage cars ", "3. Manage the staff ", "4. Extended Services ", "5. Exit " };
            int MenuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                if (MenuSelect == 0)
                {
                    Console.WriteLine("1. Register buyer of car" + "<-");
                    Console.WriteLine("2. Manage cars ");
                    Console.WriteLine("3. Manage the staff");
                    Console.WriteLine("4. Extended Services");
                    Console.WriteLine("5. Exit the menu!");
                    Console.ReadKey();
                }
                else if (MenuSelect == 1)
                {
                    Console.WriteLine("1. Register buyer of car");
                    Console.WriteLine("2. Manage cars " + "<-");
                    Console.WriteLine("3. Manage the staff");
                    Console.WriteLine("4. Extended Services");
                    Console.WriteLine("5. Exit the menu!");
                    Console.ReadKey();

                }
                else if (MenuSelect == 2)
                {
                    Console.WriteLine("1. Register buyer of car");
                    Console.WriteLine("2. Manage cars ");
                    Console.WriteLine("3. Manage the staff" + "<-");
                    Console.WriteLine("4. Extended Services");
                    Console.WriteLine("5. Exit the menu!");
                    Console.ReadKey();

                }
                else if (MenuSelect == 3)
                {
                    Console.WriteLine("1. Register buyer of car");
                    Console.WriteLine("2. Manage cars ");
                    Console.WriteLine("3. Manage the staff");
                    Console.WriteLine("4. Extended Services" + "<-");
                    Console.WriteLine("5. Exit the menu!");
                    Console.ReadKey();
                }
                else if (MenuSelect == 4)
                {
                    Console.WriteLine("1. Register buyer of car");
                    Console.WriteLine("2. Manage cars ");
                    Console.WriteLine("3. Manage the staff");
                    Console.WriteLine("4. Extended Services");
                    Console.WriteLine("5. Exit the menu!" + "<-");
                    Console.ReadKey();
                }
                var KeyPressed = Console.ReadKey();

                if (KeyPressed.Key == ConsoleKey.DownArrow && MenuSelect != menuoptions.Length - 1)
                {
                    MenuSelect++;
                }

                else if (KeyPressed.Key == ConsoleKey.UpArrow && MenuSelect >= 1)
                {
                    MenuSelect--;
                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {
                    switch (MenuSelect)
                    {
                        case 0:
                            buyer.Register();
                            break;
                        case 1:
                            car.Manage();
                            break;
                        case 2:
                            ManageStaff();
                            break;
                        case 3:
                            ExtendedServices();
                            break;
                        case 4:
                            ExitMenu();
                            break;
                    }

                }
            }
        }
        public static void Registerbuyer()
        {
            Console.WriteLine("Please input your information\n");
            Console.Write("Input your FirstName: ");
            string firstname = Console.ReadLine();
            Console.Write("Input your LastName: ");
            string lastname = Console.ReadLine();
            Console.Write("Input the car you bought: ");
            string boughtcar = Console.ReadLine();
            Console.WriteLine("Thank you for answering on the questions!");
            Console.WriteLine("Tap any button to return to menu");
            Console.ReadKey();
        }
        public static void ManageCars()
        {
            List<string> Carlist = new List<string>() { "Mercedes GLC", "Volvo XC60", "Volvo 850", "Volvo 240", "Saab 9-5" };
            foreach (string i in Carlist)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Tap any button to return to menu");
            Console.ReadKey();
        }
        public static void ManageStaff()
        {
            Console.WriteLine("Welcome, here you can see the staffs available");
            List<string> Employeelist = new List<string>() { "Henrik", "Patrik", "Karl", "Pernilla" };
            foreach (string i in Employeelist)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Tap any key to return to menu!");
            Console.ReadKey();
        }
        public static void ExtendedServices()
        {
            bool isActive = true;
            string[] sidemenu = new string[] { "1. Repair", "2. Service", "3. Warranty Case", "4. Return" };
            int sidemenuSelect = 0;
            while (isActive)
            {
                Console.Clear();
                Console.CursorVisible = false;

                if (sidemenuSelect == 0)
                {
                    Console.WriteLine("1. Repair" + "*");
                    Console.WriteLine("2. Service");
                    Console.WriteLine("3. Warranty Case");
                    Console.WriteLine("4. Return");
                    Console.ReadKey();
                }
                else if (sidemenuSelect == 1)
                {
                    Console.WriteLine("1. Repair");
                    Console.WriteLine("2. Service" + "*");
                    Console.WriteLine("3. Warranty Case");
                    Console.WriteLine("4. Return");
                    Console.ReadKey();
                }
                else if (sidemenuSelect == 2)
                {

                    Console.WriteLine("1. Repair");
                    Console.WriteLine("2. Service");
                    Console.WriteLine("3. Warranty Case" + "*");
                    Console.WriteLine("4. Return");
                    Console.ReadKey();
                }
                else if (sidemenuSelect == 3)
                {
                    Console.WriteLine("1. Repair");
                    Console.WriteLine("2. Service");
                    Console.WriteLine("3. Warranty Case");
                    Console.WriteLine("4. Return" + "*");
                    Console.ReadKey();

                }
                var KeyPressed = Console.ReadKey();
                if (KeyPressed.Key == ConsoleKey.DownArrow && sidemenuSelect != sidemenu.Length - 1)
                {
                    sidemenuSelect++;
                }
                else if (KeyPressed.Key == ConsoleKey.UpArrow && sidemenuSelect >= 1)
                {
                    sidemenuSelect--;
                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {
                    switch (sidemenuSelect)
                    {
                        case 0:
                            Repair();
                            break;
                        case 1:
                            Service();
                            break;
                        case 2:
                            WarrantyCases();
                            break;
                        case 3:
                            Return();
                            isActive = false;
                            break;
                    }
                }
            }
        }
        public static void Repair()
        {
            Console.WriteLine("You picked Reparation.\n What can we help you with");
            string reparation = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + reparation + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to get back to primary menu!");
            Console.ReadKey();

        }
        public static void Service()
        {
            Console.WriteLine("You picked Service, What can we help you with?");
            string service = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + service + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to get back to primary menu!");
            Console.ReadKey();

        }
        public static void WarrantyCases()
        {
            Console.WriteLine("You picked Warranty cases. What can we help you with?");
            string warranty = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + warranty + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to get back to primary menu!");
            Console.ReadKey();

        }
        public static void Return()
        {
            Console.WriteLine("Click Enter to close the program! ");
            Console.ReadKey();




        }

        public static void ExitMenu()
        {
            Console.WriteLine("Click any key to exit the program");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
    
       





