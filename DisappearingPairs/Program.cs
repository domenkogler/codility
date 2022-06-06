using System.ComponentModel.Design;
using System.Text;

var s = new Solution();
Console.WriteLine(s.solution("ABCBBCBA"));
Console.WriteLine(s.solution("ACCAABBC"));
Console.WriteLine(s.solution("AAA"));
Console.WriteLine(s.solution("BBBB"));
Console.WriteLine(s.solution("CCCCC"));

class Solution
{
    public string solution(string S)
    {
        if (S.Length < 2) return S;
        var stack = new Stack<char>();
        foreach (var c in S)
        {
            if (stack.Count == 0)
            {
                stack.Push(c);
                continue;
            }
            if (stack.Peek() == c)
            {
                stack.Pop();
                continue;
            }
            stack.Push(c);
        }

        return new string(stack.Reverse().ToArray());
    }
}
