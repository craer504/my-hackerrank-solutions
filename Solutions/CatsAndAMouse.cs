namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/cats-and-a-mouse/

    class CatsAndAMouse
    {
        public static string MySolution(int x, int y, int z)
        {
            return Math.Abs(x - z) == Math.Abs(y - z) ? "Mouse C" : Math.Abs(x - z) > Math.Abs(y - z) ? "Cat B" : "Cat A";
        }

        static void Test()
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = MySolution(x, y, z);

                Console.WriteLine(result);
            }
        }
    }
}