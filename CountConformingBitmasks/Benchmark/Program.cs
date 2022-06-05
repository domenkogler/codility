using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Benhcmarks>();

[MemoryDiagnoser]
public class Benhcmarks
{
    [Benchmark(Baseline = true)]
    public void Inline()
    {
        var s = new Solution1();
        s.solution(1_073_741_727, 1_073_741_631, 1_073_741_679);
    }

    [Benchmark]
    public void NewLine()
    {
        var s = new Solution2();
        s.solution(1_073_741_727, 1_073_741_631, 1_073_741_679);
    }
}