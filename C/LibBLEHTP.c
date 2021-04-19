//Copyright AnthonyOpenSource 2021

#include "LibBLEHTP.h"
#include <math.h>

double CalculatePower(int number,int powerOf)
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
      return pow(number, powerOf);
  }
}

float decode(char* data)
{
  unsigned char exponent = (unsigned char)data[0];
  int mantissa = (data[1] * 65536) + (data[2] * 256) + (data[3]);
  double result = CalculatePower((int)mantissa, (exponent));
  return (float)result;
}
