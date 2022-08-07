using System;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            int indexFileName = filePath.LastIndexOf('\\');
            int indexFileExtension = filePath.LastIndexOf('.');

            string fileName = filePath.Substring(indexFileName + 1, indexFileExtension - indexFileName - 1);
            string fileExtension = filePath.Substring(indexFileExtension + 1, filePath.Length - indexFileExtension - 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
