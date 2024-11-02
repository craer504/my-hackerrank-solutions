namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/counting-valleys/

    class CountingValleys
    {
        public static int MySolution(int steps, string path)
        {
            int numberOfValleys = 0;
            int numberOfMountains = 0;
            int altitude = 0;
            char slopeBeginning = ' ';

            for (int i = 0; i < steps; i++)
            {
                if (altitude == 0)
                {
                    slopeBeginning = path[i];
                }

                switch (path[i])
                {
                    case 'U': altitude += 1; break;
                    case 'D': altitude -= 1; break;
                    default: break;
                }

                if (altitude == 0)
                {
                    switch (slopeBeginning)
                    {
                        case 'U': numberOfMountains += 1; break;
                        case 'D': numberOfValleys += 1; break;
                        default: break;
                    }
                }
            }

            return numberOfValleys;
        }

        public static void Test()
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = MySolution(steps, path);

            Console.WriteLine(result);
        }
    }
}