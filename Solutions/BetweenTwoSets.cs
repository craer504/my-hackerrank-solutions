namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/between-two-sets/

    class BetweenTwoSets
    {
        public static int MySolution(List<int> a, List<int> b)
        {
            return Enumerable.Range(1, 100).ToList().Aggregate((count: 0, temp: 0), (acc, i) =>
            {
                if (a.All(x => i % x == 0) && b.All(x => x % i == 0))
                    ++acc.count;

                return acc;
            }).count;
        }

        public static void Test()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = MySolution(arr, brr);
        }
    }
}