using System;
using System.Collections;
using System.Collections.Generic;
public class Kata
{
  public static bool IsIsogram(string str) 
  {
    int i;
    int j;
    str = str.ToLower();
    for(i = 0; i < str.Length; ++i) {
      for(j = i + 1; j < str.Length; ++j) {
        if(str[i] == str[j]) {
          return false;
        }
      }
    }
    return true;

  }
}