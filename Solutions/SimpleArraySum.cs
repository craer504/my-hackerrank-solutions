namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/simple-array-sum/

    class SimpleArraySum
    {
        public static int MySolution(List<int> ar)
        {
            return ar.Aggregate((total, next) => total + next);
        }

        public static void Test()
        {
            int result = MySolution(new List<int> { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine(result);
        }
    }
}