package io.AnthonyOpenSource.LibBLEHTP;

//Copyright AnthonyOpenSource 2021

public class LibBLEHTP {
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
            return Math.pow(number, powerOf);
        }
    }
    public static float decode(byte[] data)
    {
        byte exponent = (byte)data[0];
        int mantissa = (data[1] * 65536) + (data[2] * 256) + (data[3]);
        double result = CalculatePower((int)mantissa, (exponent));
        return (float)result;
    }
}
