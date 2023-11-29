public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int len = nums.Length;
        int[] result = new int[2];
        for(int i1=0;i1<len;i1++){
            for(int i2=0;i2<len;i2++){
                if((nums[i1]+nums[i2]) == target && i1 != i2){
                    result = new int[2]{i1,i2};
                    return result;
                }     
            }
        }
        return new int[2]{-1,-1};
    }
}