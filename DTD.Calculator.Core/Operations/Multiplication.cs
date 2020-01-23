using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.Calculator.Core.Operations
{
    class Multiplication<T>:IOperation<T>
    {
        public T Operate(T left, T right) => (dynamic) left * (dynamic) right;

    }
}
