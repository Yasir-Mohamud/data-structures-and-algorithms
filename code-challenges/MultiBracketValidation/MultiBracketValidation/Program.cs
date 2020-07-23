using System;
using System.Collections;
using System.Collections.Generic;
using stack_and_queue;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// MultiBracketValidation - Method to evaluate strings and contained bracket pairs
        /// </summary>
        /// <param name="input">The string you want to evaluate</param>
        /// <returns>A boolean representing whether or not the brackets in the string are complementary</returns>
        public static bool MultiBracketValidationMethod(string input)
        {

            char openingRound = '(';
            char closingRound = ')';
            char openingSquare = '[';
            char closingSquare = ']';
            char openingCurly = '{';
            char closingCurly = '}';

            bool hasOpeningRound = input.Contains(openingRound);
            bool hasClosingRound = input.Contains(closingRound);
            bool hasOpeningSquare = input.Contains(openingSquare);
            bool hasClosingSquare = input.Contains(closingSquare);
            bool hasOpeningCurly = input.Contains(openingCurly);
            bool hasClosingCurly = input.Contains(closingCurly);

            stack_and_queue.Stack<char> tempStack = new stack_and_queue.Stack<char>();

            bool hasSpecialChar = false;

            var inputArray = input.ToCharArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == openingRound || inputArray[i] == closingRound || inputArray[i] == openingSquare || inputArray[i] == closingSquare || inputArray[i] == openingCurly || inputArray[i] == closingCurly)
                {
                    hasSpecialChar = true;
                }
            }

            try
            {
                if (input.Length < 2 || hasOpeningRound && !hasClosingRound || hasOpeningSquare && !hasClosingSquare || hasOpeningCurly && !hasClosingCurly
                    || !hasOpeningRound && hasClosingRound || !hasOpeningSquare && hasClosingSquare || !hasOpeningCurly && hasClosingCurly || !hasSpecialChar)
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        // filter for the opening shapes
                        if (input[i] == openingRound || input[i] == openingSquare || input[i] == openingCurly)
                        {
                            tempStack.Push(input[i]);
                        }
                        else if (input[i] == closingRound || input[i] == closingSquare || input[i] == closingCurly)
                        {

                            if (input[i] == closingRound && tempStack.Top.Value == openingRound || input[i] == closingSquare && tempStack.Top.Value == openingSquare || input[i] == closingCurly && tempStack.Top.Value == openingCurly)
                            {
                                // what if this value is null?
                                tempStack.Pop();
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (input[input.Length - 1] == openingRound || input[input.Length - 1] == openingSquare || input[input.Length - 1] == openingCurly)
                        {
                            return false;
                        }
                    }
                    return tempStack.IsEmpty();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
