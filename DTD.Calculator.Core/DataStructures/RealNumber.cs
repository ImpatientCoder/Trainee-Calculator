using System;

namespace DTD.Calculator.Core
{
    public class RealNumber:IOperatorOverLoaded
    {

        public double Value { get;  }


        public RealNumber(double value)
        {
            Value = value;
        }
        public static RealNumber operator +(RealNumber a, RealNumber b)
        {
            return new RealNumber(a.Value + b.Value);
        }
        public static RealNumber operator -(RealNumber a, RealNumber b)
        {
            return new RealNumber(a.Value - b.Value);
            
        }
        public static RealNumber operator *(RealNumber a, RealNumber b)
        {
            return new RealNumber(a.Value * b.Value);
            
        }

        public static RealNumber operator /(RealNumber a, RealNumber b)
        {
            return new RealNumber(a.Value / b.Value);
           
        }


        public void PlsOverLoad()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object b)
        {
            RealNumber realNumber = (RealNumber) b;
            return this.Value == realNumber.Value;
        }

        public static bool IsEquals(RealNumber a,RealNumber b)
        {
            return a.Value == b.Value;
        }

    }
}
