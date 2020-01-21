using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace Oyun
{
    public class Class1
    {
        static void Main(string[] args)
        {
            // Generate a random number  
            Random random = new Random();
            // Any random integer   
            int num = random.Next();

            // A random number below 100  
            int randomLessThan100 = random.Next(100);
            Console.WriteLine(randomLessThan100);

            // A random number within a range  
            int randomBetween100And500 = random.Next(100, 500);
            Console.WriteLine(randomBetween100And500);

            // Use other methods   
            RandomNumberGenerator generator = new RandomNumberGenerator();
            int rand = generator.RandomNumber(5, 100);
            Console.WriteLine($"Random number between 5 and 100 is {rand}");

            string str = generator.RandomString(10, false);
            Console.WriteLine($"Random string of 10 chars is {str}");

            string pass = generator.RandomPassword();
            Console.WriteLine($"Random password {pass}");

            Console.ReadKey();
        }

        internal static object RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }

    public class RandomNumberGenerator
    {
        // Generate a random number between two numbers    
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Generate a random string with a given size and case.   
        // If second parameter is true, the return string is lowercase  
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // Generate a random password of a given length (optional)  
        public string RandomPassword(int size = 0)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
    }
}