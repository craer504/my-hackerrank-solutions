namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/divisible-sum-pairs/

    class DivisibleSumPairs
    {
        public static int MySolution(int n, int k, List<int> ar)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = MySolution(n, k, ar);

            Console.WriteLine(result);
        }
    }
}