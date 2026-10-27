public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hs = new();
        int l = 0;
        int max = 0;
        for(int i = 0; i < s.Length; i++){
            if(!(hs.Contains(s[i]))){
                hs.Add(s[i]);
            }
            else{
                while(hs.Contains(s[i])){
                    hs.Remove(s[l]);
                    l++;
                }
                hs.Add(s[i]);
            }
            if((i - l) + 1 > max){
                max = (i - l) + 1;
            }
        }
        return max;
    }
}
