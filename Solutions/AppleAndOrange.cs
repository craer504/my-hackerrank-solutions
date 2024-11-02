namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/apple-and-orange/

    class AppleAndOrange
    {
        public static void MySolution(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var fruitSalad = apples.Concat(oranges);

            var result = fruitSalad.Aggregate((apples: 0, oranges: 0, count: 0), (acc, i) =>
            {
                if (acc.count < apples.Count && i + a >= s && i + a <= t)
                    ++acc.apples;
                else if (acc.count >= apples.Count && i + b >= s && i + b <= t)
                    ++acc.oranges;

                ++acc.count;
                return acc;
            });

            Console.WriteLine(result.apples + "\n" + result.oranges);
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            MySolution(s, t, a, b, apples, oranges);
        }
    }
}