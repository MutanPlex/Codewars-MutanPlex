using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    
    if(pin.Length == 4 || pin.Length == 6){
        if(pin.Contains('(') || pin.Contains('\\') || pin.Contains('.') || pin.Contains('<') || pin.Contains('*') || pin.Contains(';') || pin.Contains('^') || pin.Contains('|') || pin.Contains(':') || pin.Contains('¾') || pin.Contains('%') || pin.Contains('>') || pin.Contains('@') || pin.Contains('\n') || pin.Contains('-') || pin.Contains('/')){
          return false;
        }else{
          if(pin.Any(c => !char.IsDigit(c))){
            return false;
          }else{
            foreach(char a in pin){
              if(Char.IsDigit(a)){
                return true;
              }else{
                return false;
              }
            } 
          }
        }
    }
    return false;
  }
}
