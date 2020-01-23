
namespace DTD.Calculator.Core.Operations
{
    internal class Subtraction<T> : IOperation<T>
    {
        public T Operate(T left, T right) => (dynamic) left - (dynamic) right;
    }
}
