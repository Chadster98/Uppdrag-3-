using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag_3_v3
{
    public class Car
    {
        public List<string> Cars = new List<string>() { "Mercedes GLC", "Volvo XC60", "Volvo 850", "Volvo 240", "Saab 9-5" };
        public string Name { get; set; }
        public Car()
        {


        }
        public void Manage()
        {
           
            foreach (string i in Cars)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Tap any button to return to menu");
            Console.ReadKey();
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
    }
}
