namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/plus-minus/

    class PlusMinus
    {
        public static void MySolution(List<int> arr)
        {
            var result = arr.Aggregate(
                (plus: 0, minus: 0, zero: 0), (acc, i) =>
                i == 0 ? (acc.plus, acc.minus, acc.zero + 1) :
                i > 0 ? (acc.plus + 1, acc.minus, acc.zero) :
                (acc.plus, acc.minus + 1, acc.zero));

            Console.WriteLine(((double)result.plus / arr.Count).ToString("0.000000")
                + "\n" + ((double)result.minus / arr.Count).ToString("0.000000")
                + "\n" + ((double)result.zero / arr.Count).ToString("0.000000"));
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            MySolution(arr);
        }
    }
}