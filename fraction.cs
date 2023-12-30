using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examFractions
{
    struct Fraction
    {
        //fields
        public int numerator { get; set; }
        public int denominator { get; set; }

        //constructor
        public Fraction(int _numerator, int _denominator)
        {
            numerator = _numerator;
            denominator = _denominator;
        }

        //methods
        public static Fraction operator +(Fraction x) => x;
        public static Fraction operator -(Fraction x) 
            => new Fraction(-x.numerator, x.denominator);
        public static Fraction operator +(Fraction x, Fraction y)
        {
            return new Fraction(x.numerator * y.denominator + x.denominator * y.numerator, x.denominator * y.denominator);
        }
        public static Fraction operator -(Fraction x, Fraction y)
            => x + (-y);
        public static Fraction operator *(Fraction x, Fraction y)
        {
            return new Fraction(x.numerator * y.numerator, x.denominator * y.denominator);
        }
        public static Fraction operator /(Fraction x, Fraction y)
        {
            if (y.denominator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(x.numerator * y.denominator, x.denominator * y.numerator);
        }

        public override string ToString() => $"{numerator}/{denominator}";
    }
}
