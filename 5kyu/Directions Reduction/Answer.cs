using System.Linq;
using System.Text.RegularExpressions;
public class DirReduction {
  
    public static string[] dirReduc(string[] arr) {
        string s=new string(arr.Select(x=>x[0]).ToArray());
        while (Regex.Match(s,"NS|EW|SN|WE").Success) s=Regex.Replace(s,"NS|EW|SN|WE","");
        return s.Select(x=>x=='N' ? "NORTH" : x=='S' ? "SOUTH" : x=='E' ? "EAST" : "WEST").ToArray();
    }
}