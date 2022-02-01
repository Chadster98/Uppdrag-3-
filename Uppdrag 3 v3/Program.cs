using System;



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
            //Skapar variabler av de typ instanser jag behöver 
            Staff staff = new Staff("");
            Car car = new Car("", "");
            car.IntializeCars();
            Buyer buyer = new Buyer();
            
            string[] menuoptions = new string[] { "1. Register buyer of car ", "2. Manage cars ", "3. Manage the staff ", "4. Extended Services ", "5. Exit " };
            int MenuSelect = 0;
            //Medans while är sann körs menyerna nedan
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
                //Kollar användarens tryckning och att hen inte går utanför menyn.
                if (KeyPressed.Key == ConsoleKey.DownArrow && MenuSelect != menuoptions.Length - 1)
                {
                    MenuSelect++;
                }

                else if (KeyPressed.Key == ConsoleKey.UpArrow && MenuSelect >= 1)
                {
                    MenuSelect--;
                }//Läser in användarens val alternativ
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
                            staff.Manage();
                            break;
                        case 3:
                            car.ExtendedServices();
                            break;
                        case 4:
                            ExitMenu();
                            break;
                        default:
                            Console.WriteLine("Du har angivit fel siffra. Återvänder till menyn...");
                            break;
                    }

                }
            }
        }
       
       
        

      //En metod som ser till att programmet stängs ner.
        public static void ExitMenu()
        {
            Console.WriteLine("Click any key to exit the program");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
    
       





