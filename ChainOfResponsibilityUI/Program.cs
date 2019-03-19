using System;
using ChainOfResponsibilityUI.MathematicalOperations;
using ChainOfResponsibilityUI.Contracts;

namespace ChainOfResponsibilityUI
{
    class Program
    {
       static IChainOfOperations addition;
       static IChainOfOperations substraction;
       static IChainOfOperations multiplication;
       static IChainOfOperations division;
       static IChainOfOperations power;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Insert first number and click enter:");
            int.TryParse(Console.ReadLine(), out int A);
            Console.WriteLine("Insert secound number and click enter:");
            int.TryParse(Console.ReadLine(), out int B);

            AllowedOperations choosenOperation = ChooseDesiredOperation();
            Number number = new Number(A, B, choosenOperation);            

            InitializeNewOperations();
            InitializeChainOfResponsibility();           

            Console.ForegroundColor = ConsoleColor.Green;
            addition.Calculate(number);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static AllowedOperations ChooseDesiredOperation()
        {
            Console.WriteLine("What kind of operation do you want? ");
            Console.WriteLine("1. Addition ");
            Console.WriteLine("2. Substraction ");
            Console.WriteLine("3. Multiplication ");
            Console.WriteLine("4. Division ");
            Console.WriteLine("5. Power ");
            Console.WriteLine("What kind of operation do you want? ");
            string operation = Console.ReadLine();
            Enum.TryParse(operation, out AllowedOperations choosenOperation);
            return choosenOperation;
        }
        private static void InitializeNewOperations()
        {
            addition = new AddNumbers();
            substraction = new SubstractNumbers();
            multiplication = new MultiplyNumbers();
            division = new DivideNumbers();
            power = new PowerNumbers();
        }
        private static void InitializeChainOfResponsibility()
        {
            Console.WriteLine("Establishing chain of responsibility.");
            addition.NextInChain = substraction;
            substraction.NextInChain = multiplication;
            multiplication.NextInChain = division;
            division.NextInChain = power;
        }

    }
}
