namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/kaprekar-numbers/

    class ModifiedKaprekarNumbers
    {
        public static void MySolution(int p, int q)
        {
            var result = new List<long>();

            foreach (var num in Enumerable.Range(p, q - p + 1))
            {
                long sqrd = (long)num * num;
                string sqrdStr = sqrd.ToString();
                int digits = sqrdStr.Length;

                string lhsStr = sqrdStr.Substring(0, digits / 2);
                string rhsStr = sqrdStr.Substring(digits / 2);

                long lhs = lhsStr == "" ? 0 : long.Parse(lhsStr);
                long rhs = rhsStr == "" ? 0 : long.Parse(rhsStr);

                if (lhs + rhs == num)
                {
                    result.Add(num);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("INVALID RANGE");
            }
            else
            {
                result.ForEach(x => { Console.Write(x + " "); });
            }
        }

        public static void Test()
        {
            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            MySolution(p, q);
        }
    }
}