namespace ContainDuplicate;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser(false)]
public class Benchmark
{
    
    private readonly Random Random = new();
    private static int[] _collection;

    [Params(100, 1_000, 10_000)]
    public int Size{get; set;}

    [GlobalSetup]
    public void GlobalSetup()
    {
        _collection = Enumerable
        .Range(1, Size)
        .ToArray();

        var index = (int)(Size * 0.41);
        _collection[index] = _collection[index + 1];
    }

    [Benchmark]
    public bool Foreach()
    {
        return ContainsDuplicates.ContainsDuplicatesForeach(_collection);
    }

    [Benchmark]
    public bool LinqAny()
    {
        return ContainsDuplicates.ContainsDuplicatesLinqAny(_collection);
    }

    [Benchmark]
    public bool LinqAll()
    {
        return ContainsDuplicates.ContainsDuplicatesLinqAll(_collection);
    }

    [Benchmark]
    public bool LinqDistinct()
    {
        return ContainsDuplicates.ContainsDuplicatesDistinct(_collection);
    }

    [Benchmark]
    public bool ToHashSet()
    {
        return ContainsDuplicates.ContainsDuplicatesToHashSet(_collection);
    }
}