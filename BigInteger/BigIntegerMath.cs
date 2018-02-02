﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInteger
{
    public partial class BigInteger
    {
        /// <summary>
        /// Average a list of BigIntegers.
        /// 
        /// This is an easy achievement.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static BigInteger Average(IEnumerable<BigInteger> list)
        {
            return new BigInteger();
        }

        /// <summary>
        /// Find the Maximum value in a list
        /// 
        /// Easy
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static BigInteger Max(IEnumerable<BigInteger> list)
        {
            return new BigInteger();
        }

        /// <summary>
        /// Find the Minimum of the list.
        /// 
        /// Easy
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static BigInteger Min(IEnumerable<BigInteger> list)
        {
            return new BigInteger();
        }

        /// <summary>
        /// Compute the Sum of the list.
        /// 
        /// Easy
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static BigInteger Sum(IEnumerable<BigInteger> list)
        {

            return new BigInteger();
        }

        /// <summary>
        /// Determine if the number is even.
        /// 
        /// Easy
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool IsEven(BigInteger a)
        {
            //Work for base 2,4,6,8,10,12,14,16
            //BUT NOT WORK FOR 1,3,5,7,9,11,13,15,
            //EX: 5F326DA: A is ten. Even vs odd bases
            if(NUMERALS.IndexOf(a.value[0]) % 2 == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Determine if a = b (mod n)
        /// congruence mod n.
        /// This may require a little research into Algebra.
        /// 
        /// Easy achievement.
        /// Moderate achievement, if you write an explanation of Congruence Mod N.
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// 
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsCongruentModN(BigInteger a, BigInteger b, BigInteger n)
        {

            return false;
        }

        /// <summary>
        /// determine if the given BigInteger is Prime.
        /// 
        /// 
        /// This is a Hard achievement to achieve O(sqrt(n)) efficiency.
        /// It is Very Hard to achieve better than that.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool IsPrime(BigInteger a)
        {

            return false;
        }
    }
}
