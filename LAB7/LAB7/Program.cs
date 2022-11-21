//Student name: Alexander Martinez  
//Student number: 10948024

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace Lab7
{
    public class Program
    {

        static void Main()
        {
            //You could mainly use unit tests for testing.       
            
        }

    }
    public class Recursion
    {
        /// <summary>
        /// Provides the reverse of stack through the second method parameter which is modified.
        /// </summary>
        /// <param name="stack">The stack whose reverse we want to obtain. It must not be modified when method returns.</param>
        /// <param name="reversed">A stack containing the reverse of stack. Originally, reversed is an empty stack.</param>
        public static void Reverse(Stack<int> stack, Stack<int> reversed)
        {
            if(stack.Count == 0)
            {
                return;
            }
            else
            {
                reversed.Push(stack.Pop());
                Reverse(stack, reversed);
            }
        }

        /// <summary>
        /// Determines if sub is a subset of set.
        /// </summary>
        /// <param name="sub">A list representing a set of integers. Duplicate elements are allowed. sub may be modified.</param>
        /// <param name="set">A list representing a set of integers. Duplicate elements are allowed.</param>
        /// <returns>True if sub is a subset of set, false otherwise.</returns>
        public static bool IsASubset(List<int> sub, List<int> set)
        {
            
        }

        /// <summary>
        /// Finds and returns the binary equivalent of the positive integer num.
        /// </summary>
        /// <param name="num">The integer whose binary equivalent to find. num is greater than 0.</param>
        /// <returns>A string containing the binary equivalent of num.</returns>
        public static string ToBinary(int num)
        {
            
            if(num == 1)
            {
                return "1";
            }else if(num == 0)
            {
                return "0";
            }
            else
            {
                return ToBinary(num/2) + num%2;
            }
        }
    }
}

