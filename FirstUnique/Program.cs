var s = new Solution();
Console.WriteLine(s.solution(new[] { 6,4,4,6 }));
Console.WriteLine(s.solution(new[] { 1, 4, 3, 3, 1, 2 }));

class Solution
{
    public int solution(int[] A)
    {
        var dic = new Dictionary<int, bool>();
        for (int i = 0; i < A.Length; i++)
        {
            var value = A[i];
            if (dic.ContainsKey(value))
            {
                dic[value] = true;
            }
            else
            {
                dic[value] = false;
            }
        }

        try
        {
            return dic.First(kvp => !kvp.Value).Key;
        }
        catch (InvalidOperationException e)
        {
            return -1;
        }
    }
}