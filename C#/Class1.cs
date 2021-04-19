using System;

//Copyright AnthonyOpenSource 2021

namespace LibBLEHTP
{
    public static class HTPDecoder
    {
       public static double CalculatePower(int number, int powerOf)
        {
            if (powerOf < 0)
            {
                double res = number;
                for (int x = 0; x < (0 - powerOf); x++)
                {
                    res /= 10;
                }
                return res;
            }
            else
            {
                return Math.Pow(number, powerOf);
            }
        }
        public static float decode(byte[] data)
        {
          sbyte exponent = (sbyte)data[0];
          int mantissa = (data[1] * 65536) + (data[2] * 256) + (data[3]);
          double result = CalculatePower((int)mantissa, (exponent));
          return (float)result;
        }
    }
}
