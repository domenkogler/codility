var s = new Solution();
Console.WriteLine(s.solution(24));


class Solution
{
    public int solution(int N)
    {
        var count = 0;
        while (N % 2 == 0)
        {
            count ++;
            N /= 2;
        }
        return count;
    }
}