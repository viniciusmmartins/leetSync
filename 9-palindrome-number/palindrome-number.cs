public class Solution {
    public bool IsPalindrome(int x) {
        if(x.ToString() == new string(x.ToString().Reverse().ToArray()))
            return true;
        else
            return false;        
    }
}