using Algorithmus.Model;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmus
{
    class Program
    {
        static void Main(string[] args)
        {
            var summe = SummenRechner.SummeDrei(10, 10, 5, 0);
            Console.WriteLine("------Greedy------");
            var result1 = new List<double> { 2, 6, 3.5, 3, 7.5, 4 }.GreeyLoop(20);
            Console.WriteLine("-------------");


            Console.WriteLine("------Comparor------");
            var books = new List<Book>
            {
                new Book() { Author = "Athi", Pages = 2, Publish = DateTime.Now, Title = "Harry Potter"},
                new Book() { Author = "Sevi", Pages = 25, Publish = DateTime.Now, Title = "Jim und Marle"},
                new Book() { Author = "Mege", Pages = 32, Publish = DateTime.Now, Title = "Narnie"},
                new Book() { Author = "Alex", Pages = 66, Publish = DateTime.Now, Title = "Die drei ???"},
                new Book() { Author = "Lami", Pages = 89, Publish = DateTime.Now, Title = "lorem ipsum"},
                new Book() { Author = "Silvi", Pages = 13, Publish = DateTime.Now, Title = "kaminski kids"},
                new Book() { Author = "Maxi", Pages = 56, Publish = DateTime.Now, Title = "eragon"},
                new Book() { Author = "Voti", Pages = 33, Publish = DateTime.Now, Title = "Java Buch II"},
                new Book() { Author = "Schani", Pages = 277, Publish = DateTime.Now, Title = "Mani die ente"},
            };

            ConsoleTable.From<Book>(books.OrderBy(x => x.Title).OrderByDescending(x => x.Publish)).Write();
            Console.WriteLine("-------------");

            Console.WriteLine("------Palindrom------");
            Console.WriteLine($"Summe 1: {new List<int> { 23, 45, 4, 34, 3, 6, 23 }.SummeRecursion()}");
            Console.WriteLine($"Summe 2: {new List<int> { 4, 35, 34, 22, 2, 6, 3, 3 }.SummeRecursion()}");
            Console.WriteLine($"Summe 3: {new List<int> { 53, 35, 22, 1, 4, 4, 2, 7 }.SummeRecursion()}");
            Console.WriteLine("-------------");


            Console.WriteLine("------Palindrom------");
            Console.WriteLine($"ANNA: {"ANNA".IsPalindromAsRecursion()}");
            Console.WriteLine($"Reititier: {"Reititier".IsPalindromAsRecursion()}");
            Console.WriteLine($"Vogel: {"Vogel".IsPalindromAsRecursion()}");
            Console.WriteLine($"Bumba: {"Bumba".IsPalindromAsRecursion()}");
            Console.WriteLine($"Hello: {"Hello".IsPalindromAsRecursion()}");
            Console.WriteLine("-------------");
            Console.ReadKey();
        }
    }
}
