public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        for(int i = 0; i < strs.Length; i++){
            if(dict.ContainsKey(SortString(strs[i]))){
                dict[SortString(strs[i])].Add(strs[i]);
            }
            else{
                dict.Add(SortString(strs[i]), new List<string> {strs[i]});
            }
        }
        List<IList<string>> list = new();
        foreach(List<string> group in dict.Values){
            list.Add(group);
        }
        return list; 
    }
    static string SortString(string str){
        char[] charStr = str.ToArray();
        Array.Sort(charStr);
        string sorted = new string(charStr);
        return sorted;
    }
}
