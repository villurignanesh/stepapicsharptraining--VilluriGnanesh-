using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            grades book = new grades();
            book.addgrade(91f);
            book.addgrade(81.4f);
        }
    }
}
