using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    var hash = new HashSet<int>(b);
    return a.Where(_ => !hash.Contains(_)).ToArray();
  }
}