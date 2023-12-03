public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int valAnt = -2147483648 ;
        int len = nums.Length;
        for(int i = 0; i < len; i++){
            if (target>valAnt && target <= nums[i])
                return i;
            valAnt = nums[i];
        }
        return len;
    }
}