var s = new Solution();
Console.WriteLine(s.solution("ata"));
Console.WriteLine(s.solution(""));
Console.WriteLine(s.solution("x"));

class Solution
{
    public int solution(string S)
    {
        if (S.Length == 1) return 0;
        if (S.Length < 3 || S.Length % 2 == 0) return -1;
        var midpoint = (S.Length - 1) / 2;
        for (int i = 1; i <= midpoint; i++)
        {
            if (S[midpoint - i] != S[midpoint + i]) return -1;
        }
        return midpoint;
    }
}