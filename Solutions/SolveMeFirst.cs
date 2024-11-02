namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/solve-me-first/

    internal class SolveMeFirst
    {
        private static int MySolution(int a, int b)
        {
            Func<int[], int> sum = VariadicSum;
            return sum([a, b]);
        }

        private static int VariadicSum(params int[] numbers)
        {
            return numbers.Aggregate((total, next) => total + next);
        }

        public static void Test()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());

            int sum = MySolution(val1, val2);

            Console.WriteLine(sum);
        }
    }

}