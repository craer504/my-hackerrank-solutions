namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/service-lane/

    class ServiceLane
    {
        public static List<int> MySolution(int n, List<List<int>> cases, List<int> width)
        {
            return cases.Select(x => x.Aggregate((widths: width.GetRange(x[0], x[1] - x[0] + 1), min: 0), (acc, i) =>
            {
                acc.min = acc.widths.Min();
                return acc;
            }).min).ToList();
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            List<int> width = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(widthTemp => Convert.ToInt32(widthTemp)).ToList();

            List<List<int>> cases = new List<List<int>>();

            for (int i = 0; i < t; i++)
            {
                cases.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(casesTemp => Convert.ToInt32(casesTemp)).ToList());
            }

            List<int> result = MySolution(n, cases, width);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}