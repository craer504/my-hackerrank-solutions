namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/a-very-big-sum/

    class AVeryBigSum
    {
        public static long MySolution(List<long> ar)
        {
            return ar.Sum();
        }

        public static void Test()
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = MySolution(ar);

            Console.WriteLine(result);
        }
    }
}