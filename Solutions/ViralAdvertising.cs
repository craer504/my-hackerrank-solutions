namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/strange-advertising/

    class ViralAdvertising
    {
        public static int MySolution(int n)
        {
            var result = 0;
            var shared = 5;

            for (int i = 1; i <= n; i++)
            {
                var liked = shared / 2;
                shared = liked * 3;
                result += liked;
            }

            return result;
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = MySolution(n);

            Console.WriteLine(result);
        }
    }
}