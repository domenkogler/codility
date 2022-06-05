// See https://aka.ms/new-console-template for more information

var s = new Solution();
Console.WriteLine(s.solution(1041));

public class Solution
{
    public int solution(int N)
    {
        //return BinarySolution(N);
        return StringSolution(N);
    }

    public int StringSolution(int N)
    {
        const char _1 = '1';
        var binary = Convert.ToString(N, 2);
        //Console.WriteLine($"Converting {N}");
        //Console.WriteLine($"Binary: {binary}");

        var largestGap = 0;

        var last = -1;
        for (var i = 0; i < binary.Length; i++)
        {
            if (binary[i] != _1) continue;

            if (last == -1)
            {
                last = i+1;
            }
            else
            {
                var gap = i - last;
                last = i + 1;
                if (gap > largestGap)
                {
                    largestGap = gap;
                }
            }
        }

        return largestGap;
    }

    public int BinarySolution(int N)
    {
        var uN = Convert.ToUInt32(N);
        //Console.WriteLine($"Converting {uN}");
        //Console.WriteLine($"Binary: {Convert.ToString(uN, 2)}");

        var largestGap = 0;
        var position = 1;
        Next1();
        if (position == 0) return largestGap;

        do
        {
            var gap = Next1();
            if (position == 0) return largestGap;
            if (gap > largestGap) largestGap = gap;

        } while (position != 0 || position > uN);

        return largestGap;

        int Next1()
        {
            var count = 0;
            do
            {
                var is1 = (uN & position) != 0;
                position <<= 1;

                if (is1)
                {
                    return count;
                }

                if (position > uN)
                {
                    position = 0;
                    return -1;
                }

                count++;

            } while (position != 0);

            return count;
        }
    }
}
