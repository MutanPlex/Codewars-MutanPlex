using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    string [] a = str.Split(' ');
    string c = "";
    int i = 0;
    foreach(string s in a){
      if(i < a.Length - 1){
        string x = new string(s.Reverse().ToArray());
        c = c + x + " ";
      }else{
        string x = new string(s.Reverse().ToArray());
        c = c + x;
      }
      i++;
    }
    return c;
  }
}