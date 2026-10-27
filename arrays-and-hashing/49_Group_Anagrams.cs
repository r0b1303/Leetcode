public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        for(int i = 0; i < strs.Length; i++){
            string sortedString = SortString(strs[i]);
            if(dict.ContainsKey(sortedString)){
                dict[sortedString].Add(strs[i]);
            }
            else{
                dict.Add(sortedString, new List<string> {strs[i]});
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
