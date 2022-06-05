// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Benhcmarks>();

[MemoryDiagnoser]
public class Benhcmarks
{
    // public field
    [ParamsSource(nameof(ValuesForN))]
    public int N;

    public static IEnumerable<int> ValuesForN() => new[] { 0, int.MaxValue-1, 1041 };

    [Benchmark]
    public void String()
    {
        var s = new Solution();
        s.StringSolution(N);
    }

    [Benchmark(Baseline = true)]
    public void Binary()
    {
        var s = new Solution();
        s.BinarySolution(N);
    }
}