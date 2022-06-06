var s = new Solution();
Console.WriteLine(s.solution(24));

class Solution
{
    public int solution(int N)
    {
        if (N == 1) return 1;
        var root = Math.Sqrt(N);
        var count = 2;
        var current = 2;
        while (current <= root)
        {
            if (Math.Abs(current - root) < 0.0000000001) return ++count;
            if (N % current == 0) count += 2;
            current++;
        }
        return count;
    }
}