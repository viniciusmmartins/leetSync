public class Solution {
    public bool IsValid(string s) {
        if (s.Length <= 1)
            return false;
        var abertos = new List<char>();
        for(int i=0; i<s.Length; i++){
           switch(s[i]){
                case '(':
                    abertos.Add('(');
                    break;
                case '[':
                    abertos.Add('[');
                    break;
                case '{':
                    abertos.Add('{');
                    break;
                case ')':
                    if( abertos.Count > 0 && abertos.Last() == '(')
                        abertos.RemoveAt(abertos.Count - 1); 
                    else
                        abertos.Add(s[i]);
                    break;
                case ']':
                    if(abertos.Count > 0 && abertos.Last() == '[' )
                        abertos.RemoveAt(abertos.Count - 1);
                    else
                        abertos.Add(s[i]);
                    break;
                case '}':
                    if(abertos.Count > 0 && abertos.Last() == '{')
                        abertos.RemoveAt(abertos.Count - 1);
                    else
                        abertos.Add(s[i]);
                    break;
                default:
                    abertos.Add(s[i]);
                    break;
            }

        }
        return (abertos.Count == 0 ? true : false);
    }
}