public class Solution {
    public int RemoveElement(int[] nums, int val) {
         int k=0;
         foreach(var n in nums){
            if (n!=val){
                nums[k] = n;
                k++;
            }            
         }
        return k;
    }
}