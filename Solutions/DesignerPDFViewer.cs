namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/designer-pdf-viewer/

    class DesignerPDFViewer
    {
        public static int MySolution(List<int> h, string word)
        {

            var maxHeight = h[word[0] - 'a'];
            var currentCharHeight = 0;
            var rectangleLength = word.Length;

            for (int i = 1; i < word.Length; i++)
            {
                currentCharHeight = h[word[i] - 'a'];

                if (currentCharHeight > maxHeight)
                    maxHeight = currentCharHeight;
            }

            return maxHeight * rectangleLength;
        }

        public static void Test()
        {
            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

            string word = Console.ReadLine();

            int result = MySolution(h, word);

            Console.WriteLine(result);
        }
    }
}