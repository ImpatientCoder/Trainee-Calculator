

using System.Collections.Generic;
using DTD.Calculator.Core.Operations;

namespace DTD.Calculator.Core
{
    public class OperationFactory<T>where T:IOperatorOverLoaded
    {
        private static OperationFactory<T> _instance;

        public static OperationFactory<T> Instance => _instance ?? (_instance = new OperationFactory<T>());

        private OperationFactory()
        {
            Operations = new Dictionary<string, IOperation<T>>
            {
                {"+", new Addition<T>()},
                {"-", new Subtraction<T>()},
                {"/", new Division<T>()},
                {"*", new Multiplication<T>()}
            };
        }


        private Dictionary<string,IOperation<T>> Operations { get; set; }


        public IOperation<T> GetOperation(string operation)
        {
            return Operations[operation];
        }

        public bool RegisterOperation(string key,IOperation<T> operation)
        {
            if (Operations[key] != null) return false;
            Operations.Add(key,operation);
            return true;
        }


    }

 
}
