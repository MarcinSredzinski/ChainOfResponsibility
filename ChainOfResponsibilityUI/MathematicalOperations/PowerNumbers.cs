using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibilityUI.Contracts;

namespace ChainOfResponsibilityUI.MathematicalOperations
{
    public class PowerNumbers : IChainOfOperations
    {
        public IChainOfOperations NextInChain { get; set; }

        public void Calculate(Number number)
        {
            if (number.OperationWanted == AllowedOperations.power)
            {
                Console.WriteLine($"{number.NumberOne} To the power of {number.NumberTwo}" +
                       $" equals {Math.Pow(number.NumberOne,number.NumberTwo)}");
            }
            else
            {
                NextInChain.Calculate(number);
            }
        }
    }
}
