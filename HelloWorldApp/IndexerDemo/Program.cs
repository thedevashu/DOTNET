using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookLib books = new BookLib();
            books[0] = "Book of Books";
            books[1] = "Wet Water";
            books[2] = "Lava That is Hot";
            books[3] = "Boiavfa";
            books[4] = "dfvaa";
            books[5] = "dejavu";

            Console.WriteLine(books[1]);
            Console.ReadLine();
        }
    }
}
