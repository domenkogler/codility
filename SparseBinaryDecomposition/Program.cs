var s = new Solution();
s.Log(74901729);

public class Solution
{
    public void Log(int N)
    {
        Write(N);
        Write(solution(N));
        Write(N-solution(N));

        void Write(int n)
        {
            Console.WriteLine($"{n}: {Convert.ToString(n, 2)}".PadLeft(40));
        }
    }

    public int solution(int N)
    {
        return N & 0x55555555;
    }
}