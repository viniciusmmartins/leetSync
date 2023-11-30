public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string ret = "";
        if (strs[0].Length >= 1)
            for(int i = (strs[0].Length); i >0; i--)
            {
                string cw = strs[0].Substring(0, i);
                for(int j = 0;j < strs.Length; j++){
                    if(!strs[j].StartsWith(cw, true, null)){
                        ret ="";
                        break;
                    }else{
                        ret = cw;
                    }
                }
                if(ret !="")
                    break;
            } 
        return ret;     
    }
}