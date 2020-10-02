using System;

namespace Praktikum1
{
    public class Book
    {
        public string title { get; set; }

        public string author { get; }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
    }
}
