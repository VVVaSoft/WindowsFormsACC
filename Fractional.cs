using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace WindowsFormsACC
{
    public class FractionalFD
    {
        public BigInteger numerator = new BigInteger();
        public static BigInteger denominator = new BigInteger();

        public FractionalFD(BigInteger numerator)
        {
            this.numerator = numerator;
        }
        public FractionalFD(BigInteger numerator, BigInteger denominator)
        {
            this.numerator = numerator;
            FractionalFD.denominator = denominator;
        }
        public FractionalFD(FractionalFD x)
        {
            this.numerator = x.numerator;
        }
        public FractionalFD()
        {
            this.numerator = 0;
        }
        public static FractionalFD operator +(FractionalFD a, FractionalFD b)
        {
            FractionalFD ret = new FractionalFD();
            ret.numerator = a.numerator  + b.numerator;
            return ret;
        }
        public static FractionalFD operator -(FractionalFD a, FractionalFD b)
        {
            FractionalFD ret = new FractionalFD();
            ret.numerator = a.numerator - b.numerator;
            return ret;
        }
        public static FractionalFD operator *(FractionalFD a, FractionalFD b)
        {
            FractionalFD ret = new FractionalFD();
            ret.numerator = a.numerator * b.numerator;
            if (ret.numerator % FractionalFD.denominator!=0)
                throw new Exception("!!!");
            ret.numerator = ret.numerator / FractionalFD.denominator;
            return ret;
        }
        public static bool operator <(FractionalFD a, FractionalFD b)
        {
            FractionalFD c = a - b;
            if (c.numerator < 0)
                return true;
            return false;
        }
        public static bool operator >(FractionalFD a, FractionalFD b)
        {
            FractionalFD c = a - b;
            if (c.numerator < 0)
                return false;
            return true;
        }
        public static bool operator <=(FractionalFD a, FractionalFD b)
        {
            FractionalFD c = a - b;
            if (c.numerator <= 0)
                return true;
            return false;
        }
        public static bool operator >=(FractionalFD a, FractionalFD b)
        {
            FractionalFD c = a - b;
            if (c.numerator <= 0)
                return false;
            return true;
        }
        public void CopyFrom(FractionalFD a)
        {
            numerator = a.numerator;
        }
    }
}
