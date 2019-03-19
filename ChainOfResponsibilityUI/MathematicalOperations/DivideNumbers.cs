using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibilityUI.Contracts;

namespace ChainOfResponsibilityUI.MathematicalOperations
{
    public class DivideNumbers : IChainOfOperations
    {
        public IChainOfOperations NextInChain { get; set; }
        public void Calculate(Number number)
        {
            if (number.OperationWanted == AllowedOperations.division)
            {
                if (number.NumberTwo != 0)
                {
                    Console.WriteLine($"Division of {number.NumberOne} and {number.NumberTwo}" +
                        $" equals {number.NumberOne / number.NumberTwo}");
                }
                else
                {
                    Console.WriteLine("Number two is equal to zero. Operation not allowed ");
                }
            }
            else
            {
                NextInChain.Calculate(number);
            }
        }
    }
}
