using Essential6.Essential6_1;
using Essential6.Essential6_2;
using Essential6.Essential6_3;
using Essential6.Essential6_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book = Essential6.Essential6_3.Book;
using FindAndReplaceManager = Essential6.Essential6_3.FindAndReplaceManager;

namespace Essential6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(9, 71.5));
            Console.WriteLine(Calculator.Subtraction(90, 4.5));
            Console.WriteLine(Calculator.Multiply(10, 20));

            if (Calculator.Division(11, 5) != 0)
            {
                Console.WriteLine(Calculator.Division(11, 5));
            }
            else
            {
                Console.WriteLine("It is impossible to divide by zero");
            }


            Console.WriteLine(new string('-', 50));


            FindAndReplaceManager.FindNext("Hello");


            Console.WriteLine(new string('-', 50));


            Book.Note note = new Book.Note();

            note.Text = "Good book";
            note.Text = "I like it!";

            Console.WriteLine(note.Text);


            Console.WriteLine(new string('-', 50));


            int[] array = { 1, 5, 0, 2, 3, 7, 8, 9, 6 };

            array.SortUp();

            foreach (int a in array)
                Console.Write(a + "  ");

            Console.ReadKey();
        }
    }
}
