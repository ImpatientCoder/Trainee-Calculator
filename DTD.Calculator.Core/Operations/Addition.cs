using DTD.Calculator.Core.Interfaces;

namespace DTD.Calculator.Core.Operations
{
    internal class Addition<T>:IOperation<T>
    {
        public T Operate(T left, T right)=> (dynamic)left + (dynamic)right;
    }
}
