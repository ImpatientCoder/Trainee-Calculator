using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.Calculator.Core.DataStructures
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

        public static bool Equals(RealNumber a, RealNumber b)
        {
            return (a.Value == b.Value ? true : false);
        }

        public void PlsOverLoad()
        {
            throw new NotImplementedException();
        }



    }
}
