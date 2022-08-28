using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if ((a.Length == 0 && b.Length == 0))
                return true;
            if (a.Length == 0 || b.Length == 0 || a == null || b == null)
                return false;
            if (a.Length != b.Length)
                return false;
            int countT = 0;
            foreach (int i in b)
            {
                bool check = false;
                foreach(int j in a)
                {
                    if (Math.Sqrt(i) == j)
                    {
                        check = true;
                        countT++;
                        break;
                    }
                }

                if (check == false)
                    return false;
            }
            return countT == b.Length ? true : false;
  }
}