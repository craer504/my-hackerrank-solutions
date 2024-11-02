namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/bon-appetit/

    class BillDivision
    {
        public static void MySolution(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            Console.WriteLine($"{(bill.Sum() / 2 == b ? "Bon Appetit" : b - bill.Sum() / 2)}");
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            MySolution(bill, k, b);
        }
    }
}