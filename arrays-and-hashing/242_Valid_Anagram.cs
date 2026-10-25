public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<int, int> dict = new();
        if(s.Length != t.Length)
            return false; 
        //dic init
        for(int i = 0; i < s.Length; i++){
            if(!dict.ContainsKey(s[i])){
                dict.Add(s[i], 1);
            }
            else{
                int val;
                dict.TryGetValue(s[i], out val);
                dict[s[i]] = val + 1;
            }
        }
        //anagram search
        for(int i = 0; i < t.Length; i++){
            if(!dict.ContainsKey(t[i])){
                return false;
            }
            int val;
            dict.TryGetValue(t[i], out val);
            dict[t[i]] = val - 1;
        }
        foreach(int values in dict.Values){
            if(values != 0){
                return false;
            }
        }

        return true;
    }
}
