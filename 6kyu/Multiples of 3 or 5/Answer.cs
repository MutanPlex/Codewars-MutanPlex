public static class Kata
{
  public static int Solution(int value)
  {
    int answer = 0;
    if(value < 0){
      return 0;
    }else{
      for(int i = 0; i < value; i++){
        if(i % 3 == 0 || i % 5 == 0)
          answer +=i; 
      }
    }
    return answer;
  }
}