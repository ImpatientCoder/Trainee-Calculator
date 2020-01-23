

namespace DTD.Calculator.Core
{
    class Multiplication<T>:IOperation<T>
    {
        public T Operate(T left, T right) => (dynamic) left * (dynamic) right;

    }
}
