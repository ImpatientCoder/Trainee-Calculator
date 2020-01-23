
namespace DTD.Calculator.Core.Operations
{
    class Division<T>:IOperation<T>
    {
        public T Operate(T left, T right) => (dynamic) left / (dynamic) right;

    }
}
