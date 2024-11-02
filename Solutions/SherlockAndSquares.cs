namespace MyHackerRankSolutions.Solutions
{
    //https://www.hackerrank.com/challenges/sherlock-and-squares/

    class SherlockAndSquares
    {
        public static int MySolution(int a, int b)
        {
            var result = 0;
            a = (int)Math.Ceiling(Math.Sqrt(a));
            b = (int)Math.Floor(Math.Sqrt(b));

            for (int i = a; i <= b; i++)
            {
                result++;
            }

            return result;
        }

        public static void Test()
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int a = Convert.ToInt32(firstMultipleInput[0]);

                int b = Convert.ToInt32(firstMultipleInput[1]);

                int result = MySolution(a, b);

                Console.WriteLine(result);
            }
        }
    }
}