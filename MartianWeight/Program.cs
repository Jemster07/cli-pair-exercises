using System;
using System.Reflection;

namespace MartianWeight
{
    /*
    In case you've ever pondered how much you weight on Mars, here's the calculation:
    Wm = We * 0.378
    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

    Write a command line program which accepts a series of Earth weights from the user
    and displays each Earth weight as itself, and its Martian equivalent.


    C:\Users> MartianWeight
    Enter a series of Earth weights (space-separated): 98 235 185

    98 lbs.on Earth, is 37 lbs.on Mars.
    235 lbs.on Earth, is 88 lbs.on Mars.
    185 lbs.on Earth, is 69 lbs.on Mars.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Martian Weight Calculator vers. 0.0.1 ***");
            Console.WriteLine();
            Console.Write("Enter a series of Earth weights (separated by spaces): ");
            
            string userInput = Console.ReadLine();
            Console.WriteLine();
           
            char splitUnit = ' ';
            string[] inputWeight = userInput.Split(splitUnit, StringSplitOptions.RemoveEmptyEntries);

            // Variable Declaration
            const double WeightMultiplier = 0.378;
            double[] earthWeight = new double[inputWeight.Length];
            double[] marsWeight = new double[inputWeight.Length];
            int[] convertedWeight = new int[inputWeight.Length];

            for (int i = 0; i < inputWeight.Length; i++)
            {
                // convert the string array into a double array
                earthWeight[i] = double.Parse(inputWeight[i]);

                // convert to weight on Mars
                marsWeight[i] = earthWeight[i] * WeightMultiplier;

                // cast weight as "int" type
                convertedWeight[i] = (int)marsWeight[i];

                // print results to console
                Console.WriteLine($"{earthWeight[i]} lbs. on Earth is {convertedWeight[i]} lbs. on Mars.");
            }

            return;
        }
    }
}
