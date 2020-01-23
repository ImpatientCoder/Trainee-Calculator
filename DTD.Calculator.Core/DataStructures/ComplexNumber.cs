

using System;

namespace DTD.Calculator.Core
{
    public struct ComplexNumber:IOperatorOverLoaded
    {
        public void PlsOverLoad()
        {
            throw new System.NotImplementedException();
        }

        public double RealPart { get; private set; }
        public double ImaginaryPart { get; private set; }

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.RealPart + b.RealPart, a.ImaginaryPart + b.ImaginaryPart);

        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.RealPart - b.RealPart, a.ImaginaryPart - b.ImaginaryPart);
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber returnData = new ComplexNumber
            {
                RealPart = a.RealPart * b.RealPart - (a.ImaginaryPart * b.ImaginaryPart),
                ImaginaryPart = a.RealPart * b.ImaginaryPart + a.ImaginaryPart * b.RealPart
            };
            return returnData;
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber tmp = new ComplexNumber(b.RealPart, b.ImaginaryPart * -1.0);
            ComplexNumber returnData = (dynamic)a * (dynamic)tmp;
            double divider = Math.Pow(b.RealPart, 2) + Math.Pow(b.ImaginaryPart, 2);
            returnData.RealPart = returnData.RealPart / divider;
            returnData.ImaginaryPart = returnData.ImaginaryPart / divider;
            return returnData;
        }

        public static bool Equals(ComplexNumber a, ComplexNumber b)
        {
            return (a.RealPart == b.RealPart && a.ImaginaryPart == b.ImaginaryPart ? true : false);
        }


    }
}
