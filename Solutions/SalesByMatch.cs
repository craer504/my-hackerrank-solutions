namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/sock-merchant/

    class SalesByMatch
    {
        public static int MySolution(int n, List<int> ar)
        {

            var socks = new Dictionary<int, int>();

            ar.ForEach(sock =>
            {
                if (!socks.ContainsKey(sock))
                    socks[sock] = 1;
                else
                    socks[sock] += 1;
            });

            return
            socks.Aggregate((count: 0, current: 0), (acc, i) =>
            {
                acc.count += i.Value / 2;
                return acc;
            }).count;
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = MySolution(n, ar);

            Console.WriteLine(result);
        }
    }
}