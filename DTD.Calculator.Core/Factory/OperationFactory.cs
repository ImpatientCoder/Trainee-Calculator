using DTD.Calculator.Core.Operations;

namespace DTD.Calculator.Core.Factory
{
    public class OperationFactory<T>
    {
        public enum Operators
        {
            Plus,Minus,Multiplication,Division
        }

        public virtual IOperation<T> GetOperation(Operators _operator)
        {
            switch (_operator)
            {
                case Operators.Plus:
                    return new Addition<T>();
                case Operators.Minus:
                    return new Subtraction<T>();
                case Operators.Multiplication:
                    return new Multiplication<T>();
                case Operators.Division:
                    return new Division<T>();
                default:
                    return null;
            }
        }


    }

 
}
