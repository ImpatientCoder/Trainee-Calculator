namespace DTD.Calculator.Core.Interfaces
{
    public interface IOperation<T>
    {
        T Operate(T left,T right);
    }
}
