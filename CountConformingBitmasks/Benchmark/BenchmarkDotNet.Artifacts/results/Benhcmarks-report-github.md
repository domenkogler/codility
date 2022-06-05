``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


```
|  Method |     Mean |   Error |  StdDev | Ratio | Allocated |
|-------- |---------:|--------:|--------:|------:|----------:|
|  Inline | 120.9 ns | 0.32 ns | 0.25 ns |  0.72 |         - |
| NewLine | 168.5 ns | 0.21 ns | 0.16 ns |  1.00 |         - |
