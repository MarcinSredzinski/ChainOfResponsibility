using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibilityUI.Contracts;
namespace ChainOfResponsibilityUI.MathematicalOperations
{
    class SubstractNumbers : IChainOfOperations
    {
        public IChainOfOperations NextInChain { get; set; }
        public void Calculate(Number number)
        {
            if (number.OperationWanted == AllowedOperations.substraction)
            {
                Console.WriteLine($"Substraction of {number.NumberOne} and {number.NumberTwo}" +
                    $" equals {number.NumberOne - number.NumberTwo}");
            }
            else
            {
                NextInChain.Calculate(number);
            }
        }
    }
}
