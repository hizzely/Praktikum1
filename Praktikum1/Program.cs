using System;

namespace Praktikum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var book = new Book("Buku Pemrograman", "Anonim");

            Console.WriteLine(book.author);
            Console.WriteLine(book.title);
        }
    }
}