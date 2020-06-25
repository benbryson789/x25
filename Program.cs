using System;

namespace GrandCircusEncodedMessageProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            int checksum = 0;

            Console.WriteLine("What is your message?");

            string input = Console.ReadLine().ToUpper();

            foreach (char character in input)
            {
                
                message = message + $"{character - 64}-";
                checksum = checksum + character;
            }

            Console.WriteLine("Your encoded message is " + message.TrimEnd('-'));
            Console.WriteLine("Message checksum is " + checksum);


            Console.Read();
        }
    }
}
