using System;
using System.Collections.Generic;


namespace URLEncoder
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder");

            do
            {
                Console.Write("\nProject name: ");
                string projectName = GetUserInput();
                Console.Write("Activity name: ");
                string activityName = GetUserInput();

                Console.WriteLine(CreateURL(projectName, activityName));

                Console.Write("Would you like to do another? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }





        static string CreateURL(string projectName, string activityName)
        {
            // create the URL string and return it
            Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf" ,Encode(projectName), Encode(activityName));
        }





        static string GetUserInput()
        {
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (IsValid(input)) return input;
                else
                Console.Write("The input contains invalid characters. Enter again: ");
            } while (true);

        }





        static bool IsValid(string input)
        {
            foreach (char character in input.ToCharArray())
            {
                if (character == 0x00) { return false; }
                if (character == 0x01) { return false; }
                if (character == 0x02) { return false; }
                if (character == 0x03) { return false; }
                if (character == 0x04) { return false; }
                if (character == 0x05) { return false; }
                if (character == 0x06) { return false; }
                if (character == 0x07) { return false; }
                if (character == 0x08) { return false; }
                if (character == 0x09) { return false; }
                if (character == 0x0a) { return false; }
                if (character == 0x0b) { return false; }
                if (character == 0x0c) { return false; }
                if (character == 0x0d) { return false; }
                if (character == 0x0e) { return false; }
                if (character == 0x0f) { return false; }
                if (character == 0x10) { return false; }
                if (character == 0x11) { return false; }
                if (character == 0x12) { return false; }
                if (character == 0x13) { return false; }
                if (character == 0x14) { return false; }
                if (character == 0x15) { return false; }
                if (character == 0x16) { return false; }
                if (character == 0x17) { return false; }
                if (character == 0x18) { return false; }
                if (character == 0x19) { return false; }
                if (character == 0x1a) { return false; }
                if (character == 0x1b) { return false; }
                if (character == 0x1c) { return false; }
                if (character == 0x1d) { return false; }
                if (character == 0x1e) { return false; }
                if (character == 0x1f) { return false; }
                if (character == 0x7f) { return false; }
                else return true;
            }
        }




        static string Encode(string value)
        {
            string encodedValue = "";
            foreach (char character in value.ToCharArray())
            {
                // build the encodedValue string by getting each character
                // in the original string and adding it to encodedValue if the original is ok
                // OR changing it to an encoded value and adding the encoded value to the string
                // if it is one of the values that needs to change
                Console.WriteLine(System.Convert.ToInt32(character));
            }
            return encodedValue;
        }
    }
}