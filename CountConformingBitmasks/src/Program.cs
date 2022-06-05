var s = new Solution1();
Console.WriteLine(s.solution(1_073_741_727, 1_073_741_631, 1_073_741_679));

public class Solution1
{
    public const int BITS = 30;
    public int solution(int A, int B, int C)
    {
        int total = countZeros(A) + countZeros(B) + countZeros(C);
        total -= countZeros(A | B) + countZeros(B | C) + countZeros(A | C);
        total += countZeros(A | B | C);
        return total;
    }

    public static int countZeros(int n)
    {
        return countZerosInline(n);
    }

    public static int countZerosInline(int n)
    {
        var zeros = 0;
        for (var i = 0; i < BITS; i++)
        {
            if (((n >> i) & 1) == 0) zeros++;
        }
        return 1 << zeros;
    }

    public static int countZerosNewLine(int n)
    {
        var zeros = 0;
        for (var i = 0; i < BITS; i++)
        {
            if ((n & 1) == 0) zeros++;
            n >>= 1;
        }
        return 1 << zeros;
    }
}

public class Solution2
{
    public const int BITS = 30;
    public int solution(int A, int B, int C)
    {
        int total = countZeros(A) + countZeros(B) + countZeros(C);
        total -= countZeros(A | B) + countZeros(B | C) + countZeros(A | C);
        total += countZeros(A | B | C);
        return total;
    }

    public static int countZeros(int n)
    {
        return countZerosNewLine(n);
    }

    public static int countZerosInline(int n)
    {
        var zeros = 0;
        for (var i = 0; i < BITS; i++)
        {
            if (((n >> i) & 1) == 0) zeros++;
        }
        return 1 << zeros;
    }

    public static int countZerosNewLine(int n)
    {
        var zeros = 0;
        for (var i = 0; i < BITS; i++)
        {
            if ((n & 1) == 0) zeros++;
            n >>= 1;
        }
        return 1 << zeros;
    }
}