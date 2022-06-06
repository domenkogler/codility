var s = new Solution();
Console.WriteLine(s.solution(1));

class Solution
{
    public int solution(int N)
    {
        if (N == 1) return 4;
        var root = Math.Sqrt(N);
        var current = (int)root;
        while (current >= 1)
        {
            if (N % current == 0)
            {
                var a = N / current;
                var b = N / a;
                return 2 * (a + b);
            }
            current--;
        }
        return -1;
    }
}