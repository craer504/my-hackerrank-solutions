namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/electronics-shop/

    class ElectronicsShop
    {
        public static int MySolution(int[] keyboards, int[] drives, int b)
        {
            Array.Sort(keyboards);
            Array.Sort(drives);
            int i = 0;
            int j = drives.Length - 1;
            int spent = -1;

            while (i < keyboards.Length && j >= 0)
            {
                var currentTotal = keyboards[i] + drives[j];

                if (currentTotal <= b)
                {
                    spent = spent < currentTotal ? currentTotal : spent;
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return spent;
        }

        static void Test()
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

            int moneySpent = MySolution(keyboards, drives, b);

            Console.WriteLine(moneySpent);
        }
    }
}