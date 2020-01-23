namespace DTD.Calculator.Core
{
    public interface IOperation<T>
    {
        T Operate(T left,T right);
    }
}
