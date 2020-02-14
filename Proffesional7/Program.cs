using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional7
{
    class Program
    {
        static void ProtectedSection(Employee emp)
        {
            Type employee = emp.GetType();
            object[] attribute = employee.GetCustomAttributes(typeof(AccessLevelAttribute), false);

            if (attribute.Length == 0)
            {
                return;
            }

            foreach (AccessLevelAttribute item in attribute)
            {
                Console.WriteLine(item.AccessLevel);
            }
        }

        static void Main(string[] args)
        {
            Employee[] employee = new Employee[] { new Manager(), new Programmer(), new Director() };

            foreach (var emp in employee)
            {
                ProtectedSection(emp);
            }

            Console.ReadKey();

            MyClass instance = new MyClass();

            instance.ObsoleteMessage();
        }
    }
}
