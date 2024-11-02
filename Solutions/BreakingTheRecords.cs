namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/breaking-best-and-worst-records/

    class BreakingTheRecords
    {
        public static List<int> MySolution(List<int> scores)
        {
            var result = scores.Aggregate((min: 0, minCounter: 0, max: 0, maxCounter: 0, counter: 0), (acc, i) =>
            {
                if (acc.counter == 0)
                    acc.min = acc.max = i;

                if (i < acc.min)
                {
                    acc.min = i;
                    ++acc.minCounter;
                }
                else if (i > acc.max)
                {
                    acc.max = i;
                    ++acc.maxCounter;
                }

                ++acc.counter;

                return acc;
            });

            return new List<int>() { result.maxCounter, result.minCounter };
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = MySolution(scores);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}