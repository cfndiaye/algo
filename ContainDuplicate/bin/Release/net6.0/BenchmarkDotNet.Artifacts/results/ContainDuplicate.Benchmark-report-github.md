``` ini

BenchmarkDotNet=v0.13.2, OS=macOS 13.0 (22A380) [Darwin 22.1.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), Arm64 RyuJIT AdvSIMD  [AttachedDebugger]
  DefaultJob : .NET 6.0.7 (6.0.722.32202), Arm64 RyuJIT AdvSIMD


```
|       Method |  Size |        Mean |     Error |    StdDev | Allocated |
|------------- |------ |------------:|----------:|----------:|----------:|
|      **Foreach** |   **100** |    **666.3 ns** |   **3.02 ns** |   **2.83 ns** |   **2.76 KB** |
|      LinqAny |   100 |    725.2 ns |   1.77 ns |   1.66 ns |   2.84 KB |
|      LinqAll |   100 |    727.2 ns |   2.09 ns |   1.96 ns |   2.82 KB |
| LinqDistinct |   100 |    824.8 ns |   1.54 ns |   1.28 ns |   1.88 KB |
|    ToHashSet |   100 |    786.3 ns |   0.85 ns |   0.80 ns |   1.82 KB |
|      **Foreach** |  **1000** |  **4,186.7 ns** |   **4.50 ns** |   **4.21 ns** |  **12.68 KB** |
|      LinqAny |  1000 |  4,481.0 ns |   8.75 ns |   8.18 ns |  12.77 KB |
|      LinqAll |  1000 |  4,593.1 ns |   6.97 ns |   6.52 ns |  12.74 KB |
| LinqDistinct |  1000 |  7,152.1 ns |  33.94 ns |  31.75 ns |  17.45 KB |
|    ToHashSet |  1000 |  7,113.9 ns |  18.32 ns |  17.14 ns |  17.38 KB |
|      **Foreach** | **10000** | **58,000.1 ns** | **366.09 ns** | **305.70 ns** | **252.26 KB** |
|      LinqAny | 10000 | 61,354.7 ns | 779.86 ns | 691.32 ns | 252.35 KB |
|      LinqAll | 10000 | 62,872.5 ns | 572.91 ns | 507.87 ns | 252.33 KB |
| LinqDistinct | 10000 | 77,035.0 ns | 348.72 ns | 326.19 ns |  158.1 KB |
|    ToHashSet | 10000 | 76,948.1 ns | 413.81 ns | 387.08 ns | 158.03 KB |
