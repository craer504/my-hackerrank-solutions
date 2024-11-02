namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/birthday-cake-candles/

    class BirthdayCakeCandles
    {
        public static int MySolution(List<int> candles)
        {
            var candlesNumbers = new Dictionary<int, int>();

            candles.ForEach(candle =>
            {
                if (!candlesNumbers.ContainsKey(candle)) candlesNumbers.Add(candle, 1);
                else ++candlesNumbers[candle];
            });

            return candlesNumbers[candlesNumbers.Keys.Max()];
        }

        public static void Test()
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = MySolution(candles);

            Console.WriteLine(result);
        }
    }
}