public class Solution {
    public bool IsPalindrome(string s) {
        // string format
        List<char> charList = new();
        for(int i = 0; i < s.Length; i++){
            if(char.IsLetterOrDigit(s[i]) ){
                charList.Add(char.ToLower(s[i]));
            }
        }

        // palindrom check
        int l = 0;
        int r = charList.Count - 1;
        // maybe null check required
        for(int i = 0; i < charList.Count / 2; i++){
            if(l == r){
                return true;
            }
            if(!(charList[l] == charList[r])){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
