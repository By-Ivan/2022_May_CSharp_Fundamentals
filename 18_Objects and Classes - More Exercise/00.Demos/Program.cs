namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Type end: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                LoadingBar(start, end, i);
                Thread.Sleep(20);
            }
        }

        static void LoadingBar(int start, int end, int i)
        {
            double percent = (i / (double)end ) * 100;
            Console.Write($" {percent:f2}% {new string((char)122, (int)Math.Ceiling(percent) / 5)}{new string('/', (100 - (int)Math.Ceiling(percent)) / 5)}\r");
        }
    }
}