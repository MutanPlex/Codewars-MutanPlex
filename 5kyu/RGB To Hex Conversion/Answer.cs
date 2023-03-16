public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    r = r < 0 ? 0 : (r > 255 ? 255 : r);
    g = g < 0 ? 0 : (g > 255 ? 255 : g);
    b = b < 0 ? 0 : (b > 255 ? 255 : b);
    
    return ToHex(r) + ToHex(g) + ToHex(b);
  }
  private static string ToHex(int x) 
  {
      string hexChars = "0123456789ABCDEF";
      return hexChars[x/16] + "" + hexChars[x%16];
  }
}