using System.Text;

var s = new Solution();
Console.WriteLine(s.solution(20,10));

public class Solution
{
    private bool IsA;
    public string solution(int A, int B)
    {
        var length = A + B;
        var sb = new StringBuilder(length);
        IsA = B > A;
        while (sb.Length != length)
        {
            if (IsA) AddB(A, ref B, sb);
            else AddA(ref A, B, sb);
        }
        return sb.ToString();
    }

    private void AddA(ref int A, int B, StringBuilder sb)
    {
        if (A > 1 && A > B)
        {
            sb.Append("aa");
            A -= 2;
        }
        else
        {
            sb.Append("a");
            A--;
        }
        IsA = true;
    }

    private void AddB(int A, ref int B, StringBuilder sb)
    {
        if (B > 1 && B > A)
        {
            sb.Append("bb");
            B -= 2;
        }
        else
        {
            sb.Append("b");
            B--;
        }
        IsA = false;
    }
}