using Dumpify;

internal class Program

{
    private static void Main(string[] args)
    {
        IEnumerable<int> collection = [1, 2, 3, 4, 5];

        var even = collection.Where(i => i % 2 == 0);
        var fooInt = collection.OfType<int>();
        var fooSkip3 = collection.Skip(3);
        var fooTakeLast3 = collection.TakeLast(3);
        var fooLast3 = collection.Take(3);
        var fooSkipLast3 = collection.SkipLast(3);

        fooSkip3.Dump();
    }
}