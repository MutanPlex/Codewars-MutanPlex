using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static string Rot13(string message)
  {
    return !string.IsNullOrEmpty(message) ? new string(message.Select(x => (x >= 'a' && x <= 'z') ? (char)((x - 'a' + 13) % 26 + 'a') : ((x >= 'A' && x <= 'Z') ? (char)((x - 'A' + 13) % 26 + 'A') : x)).ToArray()) : message;           
  }
}