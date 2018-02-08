﻿using System;
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
            String a = "";
            for (int i = Value.Count() - 1; i > -1; i--)
            {
                a += Value[i];
            }

            return a;
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
            Value = stringRepresentation.Reverse().ToList();
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
            // Note from Cox:  So we have to restructure this loop just a little bit because of the way
            // for loops work.  It checks the condition before ever executing, so it is never executing right now.
            int i = 0;

            // Using a do-while loop here, ensures that the loop executes at least once (so if no carrying is necessary, it still runs.)
            do
            {
                if (NUMERALS.IndexOf(a.Value[i]) + 1 == a.Base)
                {
                    a.Value[i] = '0';
                    // This gets handled by the next itteration of the loop. so this line isn't needed.
                    //a.Value[i+1] = NUMERALS[NUMERALS.IndexOf(a.Value[i+1]) + 1];

                }
                else
                {
                    a.Value[i] = NUMERALS[NUMERALS.IndexOf(a.Value[i]) + 1];
                }

                // since we're not in a for loop anymore, we have to do the increment inside the method.
                i++;
            } while (i < a.Value.Count() && a.Value[i - 1] == '0');
            // and because the i has already been incremented, we have to put a i-1 in the Value[] to look back and what we just changed

            return a;
        }
        
        /// <summary>
        /// Ms. Billingsley wanted the array index opperator, so I added this ;)
        /// So, now you can say a[0] instead of a.Value[0]
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public char this[int i]
        {
            get
            {
                return this.Value[i];
            }
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

            // See if you can make this method look just like the ++ method.

			for (int i = 0; i < a.Value.Count() && a.Value[i] == 9; i++)
			{
				if (NUMERALS.IndexOf(a.Value[0]) + 1 == a.Base)
				{
					a.Value[i] = '0';
					a.Value[i] = NUMERALS[NUMERALS.IndexOf(a.Value[1]) + 1];

				}
				else
				{
					a.Value[0] = NUMERALS[NUMERALS.IndexOf(a.Value[0]) + 1];
				}
			}

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
