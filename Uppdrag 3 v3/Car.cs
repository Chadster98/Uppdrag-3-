using System;
using System.Collections.Generic;


namespace Uppdrag_3_Bilfirman
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Rust { get; set; }
        public int Miles { get; set; }



        public Car(string brand, string model, double price, int rust, int miles)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Rust = rust;
            Miles = miles;




        }

        List<Car> Cars = new List<Car>();
        public void IntializeCars() // Lägger till flera bilar manuellt
        {
            Cars.Add(new Car("Volvo", "XC60", 150000, 0, 2000));
            Cars.Add(new Car("Subaru", "Impreza", 100000, 0, 3000));
            Cars.Add(new Car("Corvette", "C6 Targa", 500000, 0, 3000));
            Cars.Add(new Car("Volvo", "V90", 250000, 0, 3000));
        }


        public void Manage() //Skriver upp bilarna på menyn och ger alternativ
        {
            Console.WriteLine();
            foreach (Car i in Cars)
            {
                Console.WriteLine(i.Brand + " " + i.Model + " " + i.Price + " " + i.Rust + " " + i.Miles);

            }
            Console.WriteLine("What would you like to do?\n");

            Console.WriteLine("1. Buy a new car");
            Console.WriteLine("2. Sell your old car");
            Console.WriteLine("3. Return to Main menu");

            Console.WriteLine("Write a number followed by pressing Enter");
            string input = Console.ReadLine();
            switch (input) // Beroende på användarens val så exekverar den just det valet
            {
                case "1":
                    Console.WriteLine("Enter the brand of car to buy.");
                    string brandToBuy = Console.ReadLine();
                    Console.WriteLine("Enter the model to buy ");
                    string modelToBuy = Console.ReadLine();
                    Console.WriteLine("Enter the amount of money the car costs");
                    int carPriceToBuy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the amount of rust the car has.");
                    int carRustToBuy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the amount of miles the car has gone.");
                    int carMilesToBuy = Convert.ToInt32(Console.ReadLine());
                    Sell(brandToBuy, modelToBuy);
                    ValueOfCar(carMilesToBuy, carPriceToBuy, carRustToBuy);
                    break;


                case "2":
                    //Tar in information om bilen som vill säljas till köparen
                    Console.WriteLine("Enter the brand of the car you want to sell.");
                    string carBrandToSell = Console.ReadLine();
                    Console.WriteLine("Enter the model of car.");
                    string carModelToSell = Console.ReadLine();
                    Console.WriteLine("Enter the amount of money you want for the car.");
                    double carPriceToSell = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the amount of rust the car has by grading it (0-3).");
                    int carRustToSell = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the amount of miles the car has gone.");
                    int carMilesToSell = Convert.ToInt32(Console.ReadLine());

                    //Testar ifall bilen ens är av värde.
                    if (carRustToSell > 3 ||  carRustToSell < 0 ||  carPriceToSell < 50000 || carMilesToSell > 10000){
                        Console.WriteLine("I dont want your car.");
                        Console.ReadKey();
                    }
                    else
                    {
                        carPriceToSell = ValueOfCar(carPriceToSell, carRustToSell, carMilesToSell);
                        addNewCar(carBrandToSell, carModelToSell, carPriceToSell, carRustToSell, carMilesToSell);
                        
                    }
                    break;

                case "3":
                    Console.WriteLine("You are returning...");
                    break;
                default:
                    Console.WriteLine("Du har angivit fel siffra. Återvänder till menyn...");
                    break;

            }
            
            //Skapar upp en bil utifrån användarens input och lägger i listan med bilar
            void addNewCar(string carBrand, string carModel, double price, int rustOnCar, int milesOnCar)
            {
                Cars.Add(new Car(carBrand, carModel, price, rustOnCar, milesOnCar));
            }
            
            //Går igenom listan och tar bort det användaren givit som märke och modell.
            void Sell(string brand, string model)
            {
                Cars.RemoveAll(x => x.Brand == brand && x.Model == model);
                Console.WriteLine("Thanks for buying a car at our firm, Drive slowly!");
                Console.ReadLine();



            }
            
            //Metod som räknar om priset beroende på rost och miltal.
            double ValueOfCar(double price, int rustOnCar, int milesOnCar)
            {              
                if (price >= 50000)
                {
                    if (rustOnCar > 0)
                    {
                        price = price * (1 - (0.1 * rustOnCar));
                    }
                    if (milesOnCar > 5000)
                    {
                        price = price * 0.9;
                    }
                    Console.WriteLine("Pleasure doing buisness with you! Here is your " + price + "USD!");
                }
                
                Console.ReadLine();
                return price;
            }
        }



        //Metod som ger information till användaren.
        public void Repair()
        {
            Console.WriteLine("You picked Reparation. What can we help you with");
            string reparation = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + reparation + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to return!");
            Console.ReadKey();

        }

        //Metod som ger information till användaren.
        public void Service()
        {
            Console.WriteLine("You picked Service,What can we help you with?");
            string service = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + service + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to return!");
            Console.ReadKey();

        }

        //Metod som ger information till användaren.
        public void WarrantyCases()
        {
            Console.WriteLine("You picked Warranty cases.What can we help you with?");
            string warranty = Console.ReadLine();
            Console.WriteLine("Okay, you need help with " + warranty + ". We will ofcourse help you.");
            Console.WriteLine("Click any button to return!");
            Console.ReadKey();

        }
        
        //Visar det valmöjligheterna som finns utöver Huvud Menyn
        public void ExtendedServices()
        {

            bool isActive = true;
            string[] sideMenu = new string[] { "1. Repair", "2. Service", "3. Warranty Case", "4. Return" };
            int sideMenuSelect = 0;
            while (isActive)
            {
                Console.Clear();
                Console.CursorVisible = false;

                if (sideMenuSelect == 0)
                {
                    Console.WriteLine("1. Repair" + " <-");
                    Console.WriteLine("2. Service");
                    Console.WriteLine("3. Warranty Case");
                    Console.WriteLine("4. Return");
                    Console.ReadKey();
                }
                else if (sideMenuSelect == 1)
                {
                    Console.WriteLine("1. Repair");
                    Console.WriteLine("2. Service" + " <-");
                    Console.WriteLine("3. Warranty Case");
                    Console.WriteLine("4. Return");
                    Console.ReadKey();
                }
                else if (sideMenuSelect == 2)
                {

                    Console.WriteLine("1. Repair");
                    Console.WriteLine("2. Service");
                    Console.WriteLine("3. Warranty Case" + " <-");
                    Console.WriteLine("4. Return");
                    Console.ReadKey();
                }
                else if (sideMenuSelect == 3)
                {
                    Console.WriteLine("1. Repair");
                    Console.WriteLine("2. Service");
                    Console.WriteLine("3. Warranty Case");
                    Console.WriteLine("4. Return" + " <-");
                    Console.ReadKey();

                }
                
                //If sats som ser till att användare inte kan gå utanför menyns visningsfält.
                var KeyPressed = Console.ReadKey();
                if (KeyPressed.Key == ConsoleKey.DownArrow && sideMenuSelect != sideMenu.Length - 1)
                {
                    sideMenuSelect++;
                }
                else if (KeyPressed.Key == ConsoleKey.UpArrow && sideMenuSelect >= 1)
                {
                    sideMenuSelect--;
                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {
                    switch (sideMenuSelect)
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
