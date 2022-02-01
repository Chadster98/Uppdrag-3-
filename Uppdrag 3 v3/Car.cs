using System;
using System.Collections.Generic;


namespace Uppdrag_3_v3
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

       
        public Car( string brand, string model)
        {
            Brand = brand;
            Model = model;



        }
        List<Car> Cars = new List<Car>();
        public void IntializeCars() // Lägger till flera bilar manuellt
        {
            Cars.Add(new Car("Volvo", "XC60"));
            Cars.Add(new Car("Subaru", "Impreza"));
            Cars.Add(new Car("Corvette", "C6 Targa"));
            Cars.Add(new Car("Volvo", "V90"));
        }
        

        public void Manage() //Skriver upp bilarna på menyn och ger alternativ
        {
            Console.WriteLine();
            foreach ( Car i in Cars)
            {
                Console.WriteLine(i.Brand + " " + i.Model);

            }
            Console.WriteLine("What would you like to do?\n");

            Console.WriteLine("1. Buy a new car");
            Console.WriteLine("2. Sell your old car");
            Console.WriteLine("3. Return to Main menu");
            string input = Console.ReadLine();
            switch (input) // Beroende på användarens val så exekverar den just det valet
            {
                    case "1":
                    Console.WriteLine("Enter the brand of car to buy.");
                    string BrandToSell = Console.ReadLine();
                    Console.WriteLine("Enter the model to buy ");
                    string ModelToSell = Console.ReadLine();
                    Sell(BrandToSell, ModelToSell);
                    break;

                    
                    case "2":
                    Console.WriteLine("Enter the brand of the car you want to sell.");
                    string carBrand = Console.ReadLine();
                    Console.WriteLine("Enter the model of car.");
                    string carModel = Console.ReadLine();
                    addNewCar(carBrand, carModel);
                    break;

                    case "3":
                    Console.WriteLine("You are returning...");
                    break;
                    default:
                    Console.WriteLine("Du har angivit fel siffra. Återvänder till menyn...");
                    break;

            }//Skapar upp en bil utifrån användarens input och lägger i listan med bilar
            void addNewCar(string carBrand, string carModel)
            {
                Cars.Add(new Car(carBrand, carModel));




            }//Går igenom listan och tar bort det användaren givit som märke och modell.
            void Sell(string brand, string model)
            {
                Cars.RemoveAll(x => x.Brand == brand &&  x.Model == model);
                

            }
            
            
            
        }
        public void Repair()
        {
            Console.WriteLine("You picked Reparation. What can we help you with");
            string reparation = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + reparation + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to return!");
            Console.ReadKey();

        }
        public void Service()
        {
            Console.WriteLine("You picked Service,What can we help you with?");
            string service = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + service + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to return!");
            Console.ReadKey();

        }
        public void WarrantyCases()
        {
            Console.WriteLine("You picked Warranty cases.What can we help you with?");
            string warranty = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + warranty + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to return!");
            Console.ReadKey();

        }//Visar det valmöjligheterna som finns utöver Huvud Menyn
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

                }//If sats som ser till att användare inte kan går utanför menyns visningsfält.
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
                    {//Tittar över det användaren väljer och går in i motsvarande case
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
                        default:
                            Console.WriteLine("Du har angivit fel siffra. Återvänder till menyn...");
                            break;
                    }
                }
            }
        }
    }
}
