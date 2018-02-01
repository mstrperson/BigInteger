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
            BigInteger a = new BigInteger("123718349137841999999");
            a--;
            Console.WriteLine(a);
            Console.ReadKey();
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
