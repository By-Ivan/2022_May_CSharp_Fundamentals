namespace _03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            List<string> results = new List<string>();

            while (input != "find")
            {
                string decryptedMessage = DecryptMessage(key, input);
                string treasureType = GetTreasureType(decryptedMessage);
                string treasureCoordinates = GetTreasureCoordinates(decryptedMessage);

                results.Add($"Found {treasureType} at {treasureCoordinates}");

                input = Console.ReadLine();
            }

            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static string GetTreasureCoordinates(string decryptedMessage)
        {
            int startIndex = decryptedMessage.IndexOf('<');
            int endIndex = decryptedMessage.IndexOf('>');
            return decryptedMessage.Substring(startIndex + 1, endIndex - startIndex - 1);
        }

        private static string GetTreasureType(string decryptedMessage)
        {
            int startIndex = decryptedMessage.IndexOf('&');
            int endIndex = decryptedMessage.LastIndexOf('&');
            return decryptedMessage.Substring(startIndex + 1, endIndex - startIndex - 1);

        }

        private static string DecryptMessage(int[] key, string input)
        {
            StringBuilder decryptedMessage = new StringBuilder();
            int keyCounter = 0;
            int keyEnd = key.Length - 1;

            for (int i = 0; i < input.Length; i++)
            {
                decryptedMessage.Append((char)(input[i] - key[keyCounter]));
                keyCounter = keyCounter == keyEnd ? 0 : keyCounter + 1;
            }

            return decryptedMessage.ToString();
        }
    }
}
