using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInteger
{
    public partial class BigInteger : IComparable<BigInteger>
    {
        public static String NUMERALS = "0123456789ABCDEF";

        /// <summary>
        /// Value represents the digits of this big integer in reverse-from-printing
        /// order so that the place value exponent is indicated by the index in the char array.
        /// </summary>
        protected List<char> Value;
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
        /// Default contructor returns zero base 10.
        /// </summary>
        public BigInteger()
        {
            Value = new List<Char>() { '0' };
            Base = 10;
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
        /// Implement the Comparable Interface for BigIntegers.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        int IComparable<BigInteger>.CompareTo(BigInteger other)
        {
            throw new NotImplementedException();
        }

        #region Automatically Generated methods.
        /// <summary>
        /// This method was automatically generated.  Ignore it for now.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var integer = obj as BigInteger;
            return integer != null &&
                   EqualityComparer<List<char>>.Default.Equals(Value, integer.Value) &&
                   Base == integer.Base;
        }

        /// <summary>
        /// This method was automatically generated.  Ignore it.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            var hashCode = 826626034;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<char>>.Default.GetHashCode(Value);
            hashCode = hashCode * -1521134295 + Base.GetHashCode();
            return hashCode;
        }
        #endregion

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
            return new BigInteger();
        }

        /// <summary>
        /// Complete the Decrement Opperator for BigIntegers.
        /// Recall the decrement Operator means subract 1 to 'a'
        /// 
        /// This is an Easy achievement.
        /// </summary>
        /// <param name="a">BigInteger to be decremented.</param>
        /// <returns>a=a-1</returns>
        public static BigInteger operator --(BigInteger a)
        {
            return new BigInteger();
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
            if (a.Base == b.Base)
            {
                // this is a Moderate Achievement.
            }
            else
            {
                // This can be Easy or Hard depending on how you approach it!
            }

            return new BigInteger();
        }

        /// <summary>
        /// Complete the Subtraction operator for BigIntegers a and b.
        /// Remember, that a and b may be represented in different bases!
        /// 
        /// This is a Moderate achievement, which contains a secondary achievement.
        /// Be clever!
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a-b</returns>
        public static BigInteger operator -(BigInteger a, BigInteger b)
        {
            if (a.Base == b.Base)
            {
                // this is a Moderate Achievement.
            }
            else
            {
                // This can be Easy or Hard depending on how you approach it!
            }

            return new BigInteger();
        }

        /// <summary>
        /// Complete the Multiplcation Operator for BigIntegers.
        /// 
        /// There are many ways to approach this, and there are varying degrees of efficiency.
        /// Can you solve this problem by mimicing a multiplication algorithm that you learned in Elementary School?
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static BigInteger operator *(BigInteger a, BigInteger b)
        {
            if (a.Base == b.Base)
            {
                // this is a Hard Achievement if you seek the most efficient algorithm.
                // Some choices of algorithm may only be an Easy achievement.
            }
            else
            {
                // This can be Easy or Hard depending on how you approach it!
            }

            return new BigInteger();
        }

        /// <summary>
        /// Complete the Integer Division Operator for BigIntegers.
        /// 
        /// this is a Very Hard Achievement if you seek the most efficient algorithm.  
        /// It may be an Easy Achievement if you choose an inefficient algorithm.
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a / b</returns>
        public static BigInteger operator /(BigInteger a, BigInteger b)
        {

            return new BigInteger();
        }

        /// <summary>
        /// Complete the Modulo operator for BigIntegers.
        /// 
        /// This may be a Very Hard achievement if you seek the most efficient algorithm,
        /// or it may be a very easy achievement if you choose a clever algorithm and solve a different problem
        /// or it may be an easy achievement if you choose an inefficient algorithm.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static BigInteger operator %(BigInteger a, BigInteger b)
        {

            return new BigInteger();
        }


        /// <summary>
        /// Complete the Less-Than operator for Big Integers
        /// 
        /// This is a moderate achievement.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator <(BigInteger a, BigInteger b)
        {

            return false;
        }

        /// <summary>
        /// Complete the greater-Than operator for Big Integers
        /// 
        /// This is a moderate achievement.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator >(BigInteger a, BigInteger b)
        {

            return false;
        }

        /// <summary>
        /// Complete the less than or equal operator for Big Integers
        /// 
        /// This is a moderate achievement.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator <=(BigInteger a, BigInteger b)
        {

            return false;
        }

        /// <summary>
        /// Complete the >= operator for Big Integers
        /// 
        /// This is a moderate achievement.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator >=(BigInteger a, BigInteger b)
        {

            return false;
        }

        /// <summary>
        /// Complete the Equal operator for Big Integers
        /// This operator should be Base Agnostic.
        /// (e.g. 17(base10) == 11(base16) should be true.
        /// 
        /// This is a moderate achievement.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(BigInteger a, BigInteger b)
        {

            return false;
        }

        /// <summary>
        /// Complete the Not Equal operator for Big Integers
        /// This operator should be Base Agnostic.
        /// (e.g. 17(base10) == 11(base16) should be true.
        /// 
        /// This is a Easy achievement.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(BigInteger a, BigInteger b)
        {

            return false;
        }
    }
}
