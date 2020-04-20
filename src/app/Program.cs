using System;
using domain.entities;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You must provide the quantity and author names");
                return;
            }

            var quantity = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                var author = new Author(args[i]);
                Console.WriteLine(author.FormatedName);
            }
        }
    }
}
