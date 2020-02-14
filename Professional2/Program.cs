using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional2
{
    class Program
    {
        public class DescendingComparer : IComparer
        {
            CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

            public int Compare(object x, object y)
            {
                int result = comparer.Compare(y, x);
                return result;
            }
        }

        static void Main(string[] args)
        {
            var sort = new SortedList();

            sort["First"] = "1st";
            sort["Second"] = "2nd";
            sort["Third"] = "3rd";
            sort["Fourth"] = "4th";

            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            Console.WriteLine(new string('-', 15));

            var sortRevers = new SortedList(new DescendingComparer());

            sortRevers["First"] = "1st";
            sortRevers["Second"] = "2nd";
            sortRevers["Third"] = "3rd";
            sortRevers["Fourth"] = "4th";

            foreach (DictionaryEntry entry in sortRevers)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }


            Console.WriteLine(new string('_', 50));


            Dictionary<Employee, List<Category>> dic = new Dictionary<Employee, List<Category>>();

            dic.Add(new Employee("Ivanov"), new List<Category> { Category.IT, Category.Other });
            dic.Add(new Employee("Petrov"), new List<Category> { Category.Other });

            foreach (KeyValuePair<Employee, List<Category>> item in dic)
            {
                Console.Write(item.Key.Name + ": ");
                foreach (var category in item.Value)
                {
                    Console.Write(category + ", ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 10));
            }

            Console.ReadKey();
        }
    }

    class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            this.Name = name;
        }
    }

    enum Category
    {
        IT, Other
    }
}
