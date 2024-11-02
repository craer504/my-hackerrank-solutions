namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/circular-array-rotation/

    class CircularArrayRotation
    {
        public static List<int> MySolution(List<int> a, int k, List<int> queries)
        {
            var newQueries = new List<int>();
            var result = new List<int>();

            int n = a.Count;
            int effectiveK = k % n;

            foreach (var q in queries)
            {
                int newQuery = (q - effectiveK + n) % n;
                newQueries.Add(newQuery);
            }

            foreach (var newIndex in newQueries)
            {
                result.Add(a[newIndex]);
            }

            return result;
        }

        public static void Test()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            int q = Convert.ToInt32(firstMultipleInput[2]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> queries = new List<int>();

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }

            List<int> result = MySolution(a, k, queries);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}