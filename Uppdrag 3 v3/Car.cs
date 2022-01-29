using System;
using System.Collections.Generic;


namespace Uppdrag_3_v3
{
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }

       
        public Car( string name, string model)
        {
            Name = name;
            Model = model;



        }
        List<Car> Cars = new List<Car>();
        public void IntializeCars()
        {
            Cars.Add(new Car("Volvo", "XC60"));
            Cars.Add(new Car("Subaru", "Impreza"));
            Cars.Add(new Car("Corvette", "C6 Targa"));
            Cars.Add(new Car("Volvo", "V90"));
        }
        

        public void Manage()
        {
           
            foreach ( Car i in Cars)
            {
                Console.WriteLine(i.Name + " " + i.Model);

            }
            
            Console.WriteLine("Tap any button to return to menu");
            Console.ReadKey();
        }
        public void Repair()
        {
            Console.WriteLine("You picked Reparation.\n What can we help you with");
            string reparation = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + reparation + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to get back to primary menu!");
            Console.ReadKey();

        }
        public void Service()
        {
            Console.WriteLine("You picked Service, What can we help you with?");
            string service = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + service + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to get back to primary menu!");
            Console.ReadKey();

        }
        public void WarrantyCases()
        {
            Console.WriteLine("You picked Warranty cases. What can we help you with?");
            string warranty = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + warranty + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to get back to primary menu!");
            Console.ReadKey();

        }
        public void ExtendedServices()
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
                            Console.WriteLine("Click Enter to close the program! ");
                            Console.ReadKey();
                            isActive = false;
                            break;
                    }
                }
            }
        }
    }
}
