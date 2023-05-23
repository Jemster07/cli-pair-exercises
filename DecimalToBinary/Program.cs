using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Decimal to Binary Converter vers. 0.0.3 ***");
            Console.WriteLine();
            Console.Write("Enter a series of decimal values (separated by spaces): ");

            string userInput = Console.ReadLine();
            Console.WriteLine();

            char splitUnit = ' ';
            string[] inputValues = userInput.Split(splitUnit, StringSplitOptions.RemoveEmptyEntries);

            // Variable Declaration
            int[] userNum = new int[inputValues.Length];
            int modulusAnswer = 0;

            for (int i = 0; i < inputValues.Length; i++)
            {
                // convert the string array into a int array
                userNum[i] = int.Parse(inputValues[i]);
            }
            
            string binaryString = "";
            
            for (int i = 0; i < userNum.Length; i++)
            {
                binaryString = "";

                while (userNum[i] >= 1)
                {
                    modulusAnswer = userNum[i] % 2;
                    userNum[i] /= 2;
                    binaryString = modulusAnswer + binaryString;
                }

                Console.WriteLine($"{inputValues[i]} in binary is {binaryString}.");
            }
            
            return;
        }
    }
}
