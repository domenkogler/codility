var s = new Solution();
Console.WriteLine(s.solution(new[] { -1, 6, 3, 4, 7, 4 }));

class Solution
{
    public int solution(int[] A)
    {
        int length = A.Length;
        var count = 0;
        for (int i = 0; i < length; i++)
        {
            var value = A[i];
            for (int j = i+1; j < length; j++)
            {
                if (value > A[j]) count++;
            }
        }

        return count;
    }
}
