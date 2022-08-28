using System;
using System.Collections;

public static class Kata 
{
  public static int TrailingZeros(int n)
  {
    int x = 0;
    if (n < 0){
      return -1;
    }
    for (int i = 5; n / i >= 1; i *= 5){
      x += n / i;
    }
    return x;
  }
}