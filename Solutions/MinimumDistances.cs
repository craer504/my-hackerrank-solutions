namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/minimum-distances/

    class MinimumDistances
    {
        public static int MySolution(List<int> a)
        {
            var d = new Dictionary<int, List<int>>();
            var result = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (d.ContainsKey(a[i]))
                    d[a[i]].Add(i);
                else
                    d.Add(a[i], new List<int> { i });
            }

            foreach (var k in d.Keys)
            {
                if (d[k].Count >= 2)
                {
                    var cur = d[k][1] - d[k][0];
                    result.Add(cur);
                }
            }

            return result.Count == 0 ? -1 : result.Min();
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = MySolution(a);

            Console.WriteLine(result);
        }
    }
}