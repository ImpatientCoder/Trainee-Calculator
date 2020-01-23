using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Calculator.Core.Interfaces;

namespace DTD.Calculator.Core.Operations
{
    internal class Subtraction<T> : IOperation<T>
    {
        public T Operate(T left, T right)
        {
            return (dynamic) left + (dynamic) right;
        }
    }
}
