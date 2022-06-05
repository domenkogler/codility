var s = new Solution();
Console.WriteLine(s.solution(new int[] { 1, 4, -1, 3, 2 }));

public class Solution
{
    public int solution(int[] A)
    {
        var count = 1;
        var value = A[0];
        for (var i = 0; i < A.Length; i++)
        {
            if (value == -1) return count;
            value = A[value];
            count++;
        }
        return -1;
    }
}