using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputBox
{

    public class Fraction
    {
        private int _Numerator;
        private int _Denominator;
        public int Numerator
        {
            get
            {
                return _Numerator;
            }
        }
        public int Denominator
        {
            get
            {
                return _Denominator;
            }
        }
        public Fraction(int theNumerator, int theDenominator)
        {
            _Numerator = theNumerator;
            _Denominator = theDenominator;
            if (_Numerator == 0)
            {
                throw new System.ArgumentException("Parameter cannot be Zero!", "numerator");
            }
            else if (_Denominator == 0)
            {
               throw new System.ArgumentException("Parameter cannot be Zero!", "denominator");
            }
            else
            {
                //    Reduce(_Numerator, _Denominator);
            }//end else
        }//end constructor
        public Fraction Add(Fraction rightFrac)
        {
            Fraction result = new Fraction((this.Numerator * rightFrac.Denominator) + (rightFrac.Numerator * this.Denominator),
                this.Denominator * rightFrac.Denominator);
            int a = gcd(result.Numerator, result.Denominator);
            return new Fraction(result.Numerator / a, result.Denominator / a);
        }

        public Fraction Munus(Fraction rightFrac)
        {
            Fraction result = new Fraction((this.Numerator * rightFrac.Denominator) - (rightFrac.Numerator * this.Denominator),
                this.Denominator * rightFrac.Denominator);

            //int a = gcd(result.Numerator, result.Denominator);
          
            return new Fraction(result.Numerator / 1, result.Denominator / 1); // return  Fraction
        }
        public Fraction Multiplay(Fraction rightFrac)
        {
            Fraction result = new Fraction((this.Numerator * rightFrac.Numerator) ,
                this.Denominator * rightFrac.Denominator);

            int a = gcd(result.Numerator, result.Denominator);

            return new Fraction(result.Numerator / a, result.Denominator / a); // return  Fraction
        }
        public Fraction Divided(Fraction rightFrac)
        {
            Fraction result = new Fraction((this.Numerator * rightFrac.Denominator),
                this.Denominator * rightFrac.Numerator);

            int a = gcd(result.Numerator, result.Denominator);

            return new Fraction(result.Numerator / a, result.Denominator / a); // return  Fraction
        }


        private int gcd(int n1, int n2)
        {
            int minimum;
            if (n1 < n2)
                minimum = n1;
            else
                minimum = n2;
            int i;
            for (i = minimum; i >= 1; i--)
            {
                if (n1 % i == 0 && n2 % i == 0)
                    break;
            }
            return i;
        }
        private int gcd2(int a, int b)
        {
            // if the remainder is 0, return second number
            if (b == 0)
                return a;

            int q = a / b;        // quotient 
            int r = a - q * b;    // remainder

            // or we can simply use a % b to calculate r

            // a becomes b and b becomes r (a % b)
            return gcd2(b, (a % b));
            // return gcd2(b, r);

        }
    }
}
  
