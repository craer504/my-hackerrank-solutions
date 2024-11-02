namespace MyHackerRankSolutions.Solutions
{
    //  https://www.hackerrank.com/challenges/compare-the-triplets/

    class CompareTheTriplets
    {
        public static List<int> MySolution(List<int> a, List<int> b)
        {
            return new List<int> { a.Zip(b, (x, y) => x > y ? 1 : 0).Sum(), b.Zip(a, (x, y) => x > y ? 1 : 0).Sum() };
        }

        public static void Test()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = MySolution(a, b);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}