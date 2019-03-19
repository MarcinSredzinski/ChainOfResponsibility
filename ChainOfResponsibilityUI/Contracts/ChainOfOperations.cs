using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityUI.Contracts
{
  
    public interface IChainOfOperations
    {
        IChainOfOperations NextInChain { get; set; }
        void Calculate(Number number);
    }
}
