using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityUI
{
    public enum AllowedOperations
    {
        addition = 1,
        substraction = 2,
        multiplication = 3,
        division = 4,
        power = 5
    }
    public class Number
    {
        public Number(int numberOne, int numberTwo, AllowedOperations operationWanted)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
            OperationWanted = operationWanted;
        }

        public int NumberOne { get; private set; }
        public int NumberTwo { get; private set; }
        public AllowedOperations OperationWanted { get; private set; }
    }
}
