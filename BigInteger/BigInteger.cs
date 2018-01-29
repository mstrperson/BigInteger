using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInteger
{
    public class BigInteger
    {
        public static String NUMERALS = "0123456789ABCDEF";

        /// <summary>
        /// Value represents the digits of this big integer in reverse-from-printing
        /// order so that the place value exponent is indicated by the index in the char array.
        /// </summary>
        protected char[] Value;
        public int Base { get; protected set; }

        /// <summary>
        /// Use a Loop to recombine the chars from the Value property to print the
        /// Big integer in human readable form. 
        /// 
        /// This is an Easy achievement.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Use a loop to take the characters from stringRepresentation and put them
        /// into the Value property.
        /// 
        /// this is an Easy achievement.
        /// 
        /// Additionally, check to make sure that there are no invalid characters.
        /// If an invalid character is found, throw an InvalidCastException.
        /// 
        /// This is also an Easy achievement.
        /// </summary>
        /// <param name="stringRepresentation">String representation of a number</param>
        /// <param name="number_base">Base that this number is written in.  2 to 16 are valid.</param>
        public BigInteger(String stringRepresentation, int number_base = 10)
        {
            Base = number_base;
            // TODO: Write the constructor.
        }

        /// <summary>
        /// Change the base of this BigInteger.  Update the Value property to have the same value written
        /// in the new base.
        /// 
        /// This is a Medium Achievement.
        /// </summary>
        /// <param name="new_base"></param>
        public void ChangeBase(int new_base)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Complete the Increment Opperator for BigIntegers.
        /// Recall the Increment Operator means Add 1 to 'a'
        /// 
        /// This is an Easy achievement.
        /// </summary>
        /// <param name="a">BigInteger to be incremented.</param>
        /// <returns>a=a+1</returns>
        public static BigInteger operator ++(BigInteger a)
        {
            return a;
        }


        /// <summary>
        /// Complete the Addition operator for BigIntegers a and b.
        /// Remember, that a and b may be represented in different bases!
        /// 
        /// This is a Moderate achievement, which contains a secondary achievement.
        /// Be clever!
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        public static BigInteger operator +(BigInteger a, BigInteger b)
        {
            if(a.Base == b.Base)
            {
                // this is a Moderate Achievement.
            }
            else
            {
                // This can be Easy or Hard depending on how you approach it!
            }

            return a;
        }
    }
}
