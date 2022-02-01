using System;

namespace Uppdrag_3_v3
{
    public class Buyer
    {
        public string _firstName
        {
            get; set;
        }
        public string _lastName { get; set; }
        public Car _Car { get; set; }
        //Registrera köpare
        public void Register()
        {
            Console.WriteLine("Please input your information\n");
            Console.Write("Input your FirstName: ");
            string firstName = Console.ReadLine();
            _firstName = firstName;
            Console.Write("Input your LastName: ");
            string lastName = Console.ReadLine();
            _lastName = lastName;
            Console.Write("Input the car you bought: ");
            string boughtCar = Console.ReadLine();
            Console.WriteLine("Thank you for answering on the questions!");
            Console.WriteLine("Tap any button to return to menu");
            Console.ReadKey();
        }
    }
}
