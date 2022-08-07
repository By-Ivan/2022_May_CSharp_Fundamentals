using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Articles2_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] articleInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);
                articles.Add(article);
            }
            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}