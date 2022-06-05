var s = new Solution();
Console.WriteLine(s.solution("test 5 a0A pass007 ?xy1"));

class Solution
{
    private const char _a = 'a';

    public int solution(string S)
    {
        var words = S
            .Split(" ")
            .Select(s => s.ToLowerInvariant())
            .Where(w => w.All(IsAlphaNumerical) && CountLetters(w) % 2 == 0 && CountDigit(w) % 2 == 1)
            .OrderByDescending(w => w.Length);
        var pass = words.FirstOrDefault();
        return pass?.Length ?? -1;
    }

    static int CountLetters(string word) => word.Where(IsLower).Count();
    static int CountDigit(string word) => word.Where(IsDigit).Count();
    static bool IsAlphaNumerical(char c) => IsLower(c) || IsDigit(c);
    static bool IsLower(char c) => IsInRange(c, 'a', 'z');
    static bool IsDigit(char c) => IsInRange(c, '0', '9');
    static bool IsInRange(char c, char min, char max) => (uint)(c - min) <= (uint)(max - min);
}