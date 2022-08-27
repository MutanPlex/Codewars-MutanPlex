public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
    int m,n;
    for(int i = 0; i < numbers.Length; i++){
      for(int j = 0; j < numbers.Length; j++){
        if(numbers[i] < numbers[j]){
          m = numbers[i];
          n = numbers[j];
          numbers[i] = n;
          numbers[j] = m;
        }
      }
    }
    int answer = numbers[0] + numbers[1];
    return answer;
	}
}