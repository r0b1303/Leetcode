public class Solution {
    public int[][] Merge(int[][] intervals) {
        List<int[]> result = new();
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        int newstart = intervals[0][0];
        int newend = intervals[0][1];

        for(int i = 0; i < intervals.Length - 1; i++){
            if(intervals[i + 1][0] <= newend){
                newend = Math.Max(newend, intervals[i + 1][1]);
                newstart = Math.Min(newstart, intervals[i + 1][0]);
            }
            else{
                result.Add(new int[]{newstart, newend});
                newstart = intervals[i + 1][0];
                newend = intervals[i + 1][1];
            }
        }
        result.Add(new int[]{newstart, newend});
        return result.ToArray();
    }
}
