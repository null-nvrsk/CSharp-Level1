using System;

namespace _1_Complex
{
    class Complex
    {
        public double a, b;

        //---------------------------------------------------------------------
        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        //---------------------------------------------------------------------
        public override string ToString()
        {
            return (b >= 0) ? $"{a} + {b}i" : $"{a} - {-b}i";
        }

        //---------------------------------------------------------------------
        public static Complex Plus(Complex z1, Complex z2)
        {
            return new Complex(
                a: z1.a + z2.a,
                b: z1.b + z2.b
            );
        }            
        
        public static Complex operator +(Complex z1, Complex z2)
        {
            return new Complex(
                a: z1.a + z2.a,
                b: z1.b + z2.b
            );
        }

        //---------------------------------------------------------------------
        public static Complex Sub(Complex z1, Complex z2)
        {
            return new Complex(
                a: z1.a - z2.a,
                b: z1.b - z2.b
            );
        }             
        
        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex(
                a: z1.a - z2.a,
                b: z1.b - z2.b
            );
        }        
        
        //---------------------------------------------------------------------
        public static Complex Multi(Complex z1, Complex z2)
        {
            return new Complex(
                a: (z1.a * z2.a) - (z1.b * z2.b),
                b: (z1.a * z2.b) + (z1.b * z2.a)
            );
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return new Complex(
                a: (z1.a * z2.a) - (z1.b * z2.b),
                b: (z1.a * z2.b) + (z1.b * z2.a)
            );
        }
    }
}
