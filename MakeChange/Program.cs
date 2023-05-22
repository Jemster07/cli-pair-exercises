using System;
using System.Threading.Channels;

namespace MakeChange
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.

        C:\Users> MakeChange

        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            Console.WriteLine(" -* Calculating Change... For Dummies v0.0.2 *-  ");
            Console.WriteLine();
            //ask for bill amount
            Console.Write("Please enter amount billed: ");
            //create varialbe for amount entered
            string amountEntered = "";
            amountEntered = Console.ReadLine();
            decimal enteredConversion = decimal.Parse(amountEntered);
            Console.WriteLine($"Your total Bill is: {enteredConversion:C2}");

            //ask for amount tendered
            Console.Write("Please enter amount tendered: ");
            //create variable for amount entered
            string amountTendered = "";
            amountTendered = Console.ReadLine();
            decimal tenderedConversion = decimal.Parse(amountTendered);
            while(tenderedConversion < enteredConversion)
            {
                Console.Write("Stealing is bad, Please pay full amount... ");
                amountTendered = Console.ReadLine();
                tenderedConversion = decimal.Parse(amountTendered);
            }
            Console.WriteLine($"The amount tendered is: {tenderedConversion:C2}");

            //create code for conversion
            decimal changeRequired = tenderedConversion - enteredConversion;
            
            // change amount = amount tendered - amount owed
            
            //print change required
            Console.WriteLine($"Your change due is: {changeRequired:C2}");
        }
    }
}
