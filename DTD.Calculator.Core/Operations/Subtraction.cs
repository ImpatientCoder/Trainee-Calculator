
namespace DTD.Calculator.Core
{
    internal class Subtraction<T> : IOperation<T>
    {
        public T Operate(T left, T right) => (dynamic) left - (dynamic) right;
    }
}
