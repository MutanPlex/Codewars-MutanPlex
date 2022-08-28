using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
  public static string PigIt(string str) {

        var words = str.Split(' ');
        var sb = new StringBuilder();
        int j = 1;
        foreach (var word in words) {
            var firstChar = word[0];
            if (char.IsPunctuation(firstChar))
                sb.Append(firstChar + "");
            else {
              if(words.Length != j)
                sb.Append(word.Remove(0,1) + firstChar + "ay ");
              else
                sb.Append(word.Remove(0,1) + firstChar + "ay");
            }
            j++;
        }
        return sb.ToString();
    }

}