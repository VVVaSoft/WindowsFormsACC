using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Diagnostics;


namespace WindowsFormsACC
{
    class ACC
    {
        public static byte[] Compress(byte[] byf)
        {
            int []weight=new int [256];
            for(int i=0;i<256;i++)
                weight[i]=1;

            BigInteger den = 1;
            for (int i = 0; i < byf.Length; i++)
                den *= (256 + i);

            FractionalFD a = new FractionalFD(0, den), b = new FractionalFD(den, den);
            for (int i = 0; i < byf.Length; i++){
                packByte(ref a, ref b,weight,byf[i]);
                weight[byf[i]]++;
            }

            Debug.Print("");
            byte[] ret = GetActualMarkBytes(a, b);
            return ret;
        }
        private static void packByte(ref FractionalFD a, ref FractionalFD b, int []weight, byte data)
        {
            int sum=0;
            for(int i=0;i<weight.Length;i++)
                sum+=weight[i];

            FractionalFD left = new FractionalFD(a.numerator), rite = new FractionalFD(a.numerator);
            FractionalFD LenRL = b - a;
            Debug.Print("{0}", left.numerator);

            for(int i=0;i<weight.Length;i++)
            {
                rite.CopyFrom(left);
                rite += LenRL * new FractionalFD(FractionalFD.denominator * weight[i] / sum);
                Debug.Print("{0}", rite.numerator);

                if(((byte)i)==data)
                {
                    a.CopyFrom(left);
                    b.CopyFrom(rite);
                    return;
                }
                left.CopyFrom(rite);
            }
            return;
        }
        private static byte[] GetActualMarkBytes(FractionalFD a, FractionalFD b)
        {

            Debug.Print("a={0}", a.numerator);
            List<byte> aa = new List<byte>();
            List<byte> bb = new List<byte>();
            List<byte> ret = new List<byte>();

            for (int i=0;;i++)
            {
                if ((FractionalFD.denominator >> i*8) != 0)
                {
                    aa.Add((byte)((a.numerator >> (int)(i * 8)) & 0xff));// в начале младший
                    bb.Add((byte)((b.numerator >> (int)(i * 8)) & 0xff));
                }
                else
                    break;
            }

            for (int i=aa.Count-1; ; i--)
            {
                if (aa[i] == bb[i])
                {
                    ret.Insert(0, aa[i]);
                }
                else if ((uint)bb[i] - (uint)aa[i]<2)
                {
                    ret.Insert(0, aa[i]);
                }
                else
                {
                    byte t = (byte)(((uint)aa[i] + (uint)bb[i]) / 2);
                    ret.Insert(0, t);
                    break;
                }
            }
            return ret.ToArray();
        }
        //=============================================================================
        private static FractionalFD GetMarkFractional(byte[] buf)
        {
            BigInteger mark = 0;
            for(int i=buf.Length-1;i>=0;i--)
            {
                mark=mark<<8;
                mark|=buf[i];
            }

            int lenMark = 0;
            int lenDen = 0;
            for (int i=0; ;i++ ) { 
                BigInteger TmpMark=mark>>(8*i);
                BigInteger TmpDen=FractionalFD.denominator>>(8*i);

                if (TmpMark != 0)
                    lenMark++;
                if (TmpDen != 0)
                    lenDen++;

                if (TmpMark == 0 && TmpDen == 0)
                    break;
            }

            mark = mark << 8 * (lenDen - lenMark);//!!!
            
            FractionalFD ret=new FractionalFD(mark);
            Debug.Print("a={0}",ret.numerator);

            return ret;
        }
        public static byte[] DeCompress(byte[] buf, int lenSrc)
        {
            int[] weight = new int[256];
            for (int i = 0; i < 256; i++)
                weight[i] = 1;

            BigInteger den = 1;
            for (int i = 0; i < lenSrc; i++)
                den *= (256 + i);

            List<byte> ret = new List<byte>();
            FractionalFD a = new FractionalFD(0, den), b = new FractionalFD(den, den);
            FractionalFD mark = GetMarkFractional(buf);

            while (ret.Count < lenSrc)
            {

                byte br=unPackByte(ref a, ref b, weight, mark);
                ret.Add(br);
                weight[br]++;
            }

            Debug.Print("");
            return ret.ToArray();
        }
        private static byte unPackByte(ref FractionalFD a, ref FractionalFD b, int[] weight, FractionalFD mark)
        {
            int sum = 0;
            for (int i = 0; i < weight.Length; i++)
                sum += weight[i];

            FractionalFD left = new FractionalFD(a.numerator), rite = new FractionalFD(a.numerator);
            FractionalFD LenRL = b - a;
            Debug.Print("{0}", left.numerator);
            for (int i = 0; i < weight.Length; i++)
            {
                rite.CopyFrom(left);
                rite += LenRL * new FractionalFD(FractionalFD.denominator * weight[i] / sum);
                Debug.Print("{0}", rite.numerator);
                if (left <= mark && mark < rite)
                {
                    a.CopyFrom(left);
                    b.CopyFrom(rite);
                    return (byte)i;
                }
                left.CopyFrom(rite);
            }
            throw new Exception("!!!");
        }
    }
}
