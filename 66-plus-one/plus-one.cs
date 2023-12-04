public class Solution {
    public int[] PlusOne(int[] digits) {
      digits = digits.Reverse().ToArray();
        int len = digits.Length;
        int goOne = 1;
        List<int> result = new List<int>();
        for(int i = 0; i < len; i++){
          int _sum = digits[i] + goOne;
          if(_sum>9){
              result.Add(0);
              goOne = 1;   
          }else{
              result.Add(_sum);
              goOne = 0;
          }
          if (i+1 == len && goOne == 1){
              result.Add(1);
          }  
        }
        return result.ToArray().Reverse().ToArray();;
    }
}