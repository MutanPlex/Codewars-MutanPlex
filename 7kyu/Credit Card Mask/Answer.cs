public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    char[] charArr = cc.ToCharArray();
    
    if(charArr.Length > 4){
      for(int i = 0; i < charArr.Length - 4; i++){
        charArr[i] = '#';
      }
    }
    string answer = "";
    foreach(char c in charArr){
      answer = answer + c;
    }
    return answer;
  }
}
