using System;
using System.Linq;

public class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        return b != null && a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
    }
}
