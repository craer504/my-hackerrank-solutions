namespace MyHackerRankSolutions.Solutions
{
    //  https://www.hackerrank.com/challenges/library-fine/

    class LibraryFine
    {
        public static int MySolution(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            var fee = 0;

            var returnDate = new DateTime(y1, m1, d1);
            var dueDate = new DateTime(y2, m2, d2);

            if (returnDate > dueDate)
            {
                if (returnDate.Year > dueDate.Year)
                {
                    fee = 10000;
                }
                else if (returnDate.Month > dueDate.Month)
                {
                    fee = (returnDate.Month - dueDate.Month) * 500;
                }
                else if (returnDate.Day > dueDate.Day)
                {
                    fee = (returnDate.Day - dueDate.Day) * 15;
                }
            }

            return fee;
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d1 = Convert.ToInt32(firstMultipleInput[0]);

            int m1 = Convert.ToInt32(firstMultipleInput[1]);

            int y1 = Convert.ToInt32(firstMultipleInput[2]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d2 = Convert.ToInt32(secondMultipleInput[0]);

            int m2 = Convert.ToInt32(secondMultipleInput[1]);

            int y2 = Convert.ToInt32(secondMultipleInput[2]);

            int result = MySolution(d1, m1, y1, d2, m2, y2);

            Console.WriteLine(result);
        }
    }
}