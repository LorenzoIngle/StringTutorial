using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to encrypt:");
            string userInput = Console.ReadLine();
            string encryptedString = " ";
            try
            {
                 encryptedString = EncryptString(userInput);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("no input detected");
            }
            catch (ArgumentOutOfRangeException) 
            {
                Console.WriteLine("input is wrong format");
            }
            finally
            {
                Console.WriteLine(encryptedString);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        static string EncryptString(string inputString)
        {
            // Guard clause to check if input is a valid string
            if (string.IsNullOrEmpty(inputString))
            {
                throw new ArgumentNullException(nameof(inputString), "Input string must not be null or empty");
            }
            // Reverse the string
            char[] temp = inputString.ToCharArray();
            Array.Reverse(temp);
            string reverseString = new String(temp);

            // Convert every second charatcer to uppercase
            for (int i = 0; i<reverseString.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Char.ToUpper(reverseString[i]);
                }
            }

            // Interpolateion and concatenation


            // String conversion using ASCII values to shift each character by 1


            //string finalEncryption = new string(finalEncryptionChars);
            string finalEncryption = reverseString;
            return finalEncryption;
        }
    }
}
