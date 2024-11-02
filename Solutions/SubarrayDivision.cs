class SubarrayDivision
{
    // https://www.hackerrank.com/challenges/the-birthday-bar/

    public static int MySolution(List<int> s, int d, int m)
    {
        return s
            .Select((x, i) => new { Index = i, Value = x })
            .Where(x => x.Index <= s.Count - m)
            .Select(x => s.Skip(x.Index).Take(m).ToList())
            .Where(x => x.Sum() == d)
            .ToList()
            .Count;
    }

    public static void Test()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = MySolution(s, d, m);

        Console.WriteLine(result);
    }
}
