public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int valAnt = -2147483648 ;
        for(int i = 0; i < nums.Length; i++){
            if (target>valAnt && target <= nums[i])
                return i;
            valAnt = nums[i];
        }
        return nums.Length;
    }
}