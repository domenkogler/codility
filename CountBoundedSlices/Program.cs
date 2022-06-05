// See https://aka.ms/new-console-template for more information
var s = new Solution();
Console.WriteLine(s.solution(2, new[] { 3, 5, 7, 6, 3 }));

class Solution
{
    public int solution(int K, int[] A)
    {
        var count = 0;
        var max = 0;
        var min = 0;
        for (int i = 0; i < A.Length; i++)
        {
            max = A[i];
            min = max;
            for (int j = i; j < A.Length; j++)
            {
                max = Math.Max(max, A[j]);
                min = Math.Min(min, A[j]);
                if (max - min <= K) count++;
                else break;
            }
            if (count > 1_000_000_000) return 1_000_000_000;
        }
        return count;
    }
}
