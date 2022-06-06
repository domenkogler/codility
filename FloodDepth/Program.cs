var s = new Solution();
Console.WriteLine(s.solution(new[] { 1, 3, 2, 1, 2, 1, 5, 3, 3, 4, 2 }));

class Solution
{
    public int solution(int[] A)
    {
        int depth = 0;
        int max = 0;
        int min = 0;

        for (int i = 0; i < A.Length; i++)
        {
            var value = A[i];
            var d = 0;
            if (value > max)
            {
                d = max - min;
                max = value;
                min = value;
            }
            else if (value < min)
            {
                min = value;
            }
            else
            {
                d = value - min;
            }

            if (d > depth)
            {
                depth = d;
            }
        }

        return depth;
    }
}
