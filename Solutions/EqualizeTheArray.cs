namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/equality-in-a-array/

    class EqualizeTheArray
    {
        public static int MySolution(List<int> arr)
        {
            return arr
                .GroupBy(x => x)
                .OrderBy(x => x.Count())
                .SkipLast(1)
                .Sum(x => arr.Count(y => y == x.Key));
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = MySolution(arr);

            Console.WriteLine(result);
        }
    }
}