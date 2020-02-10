using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential15.Essential15_2
{
    class Company
    {
        Worker[] staff;

        public Company()
        {
            string name;
            string post;
            int year;
            string tmp;

            staff = new Worker[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter employee name");
                name = Console.ReadLine();

                Console.WriteLine("Enter position");
                post = Console.ReadLine();

                Console.WriteLine("Enter the year you started work ");
                tmp = Console.ReadLine();

                try
                {
                    year = Convert.ToInt32(tmp);
                }
                catch (Exception e)
                {
                    Console.WriteLine("You entered an invalid year value.");
                    Console.WriteLine(e.Message);
                    year = DateTime.Now.Year;
                }

                staff[i] = new Worker(name, post, year);
                Console.Clear();
            }
            staff = staff.OrderBy(worker => worker.Name).ToArray<Worker>();
        }

        public string this[int index]
        {
            get
            {
                string answer = "";
                for (int i = 0; i < staff.Length; i++)
                {
                    if (staff[i].Experience() > index)
                    {
                        answer += "Surname of the employee " + staff[i].Name + "\n";
                    }

                }
                if (answer.Length >= 0)
                {
                    return answer;
                }
                return "No employees with such work experience";
            }
        }
    }
}
