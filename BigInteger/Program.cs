using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            BigInteger a = new BigInteger(Console.ReadLine());
            Console.WriteLine("Input second number");
            BigInteger b = new BigInteger(Console.ReadLine());
            Console.WriteLine(a+b);
            Console.ReadKey();
        }


        public static void ExampleStringInteraction()
        {
            Console.Write("Enter a number:  ");
            String number = Console.ReadLine();
            Console.Write("What base is this in?  ");
            int nBase = Convert.ToInt32(Console.ReadLine());

            List<char> reversedList = new List<char>();
            
            for(int i = number.Length-1; i > -1; i--)
            {
                char ch = number[i];
                if(BigInteger.NUMERALS.IndexOf(ch) == -1 || BigInteger.NUMERALS.IndexOf(ch) >= nBase)
                {
                    Console.WriteLine("This number has an invalid NUMERAL for that base.  It's wrong~");                    
                }
                else
                {
                    reversedList.Add(ch);
                }
            }
        }

        /// <summary>
        /// Devise a method of using the System Time to calculate the execution time of a method.  This will help you
        /// determine the efficiency of the method.
        /// 
        /// This is a Moderate achievement.
        /// </summary>
        public static void CalculateExecutionTime()
        {

        }
    }
}
