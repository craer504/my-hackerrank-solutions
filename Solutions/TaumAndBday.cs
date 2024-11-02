namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/taum-and-bday/

    class TaumAndBday
    {
        public static long MySolution(int b, int w, int bc, int wc, int z)
        {
            long result = 0;
            long longW = w;
            long longB = b;
            long longWc = wc;
            long longBc = bc;
            long wToB = wc + z;
            long bToW = bc + z;

            if (wToB < longBc)
            {
                result += longB * wToB;
            }
            else
            {
                result += longB * longBc;
            }

            if (bToW < longWc)
            {
                result += longW * bToW;
            }
            else
            {
                result += longW * longWc;
            }

            return result;
        }

        public static void Test()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int b = Convert.ToInt32(firstMultipleInput[0]);

                int w = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int bc = Convert.ToInt32(secondMultipleInput[0]);

                int wc = Convert.ToInt32(secondMultipleInput[1]);

                int z = Convert.ToInt32(secondMultipleInput[2]);

                long result = MySolution(b, w, bc, wc, z);

                Console.WriteLine(result);
            }
        }
    }
}