using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibilityUI.Contracts;
namespace ChainOfResponsibilityUI.MathematicalOperations
{
    class MultiplyNumbers : IChainOfOperations
    {
        public IChainOfOperations NextInChain { get; set; }
        public void Calculate(Number number)
        {
            if (number.OperationWanted == AllowedOperations.multiplication)
            {
                Console.WriteLine($"Multiplication of {number.NumberOne} and {number.NumberTwo}" +
                    $" equals {number.NumberOne * number.NumberTwo}");
            }
            else
            {
                NextInChain.Calculate(number);
            }
        }
    }
}
