using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional16
{
    class Program
    {
        delegate void DelegateModifier();

        static void Main(string[] args)
        {
            List<int> listOriginal = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Func<List<int>> func = () =>
            {
                List<int> list = new List<int>();
                foreach (var item in listOriginal)
                {
                    list.Add(item * 2);
                }
                return list;
            };

            List<int> listNew = func();

            foreach (var item in listNew)
            {
                Console.WriteLine(item);
            }

            DelegateModifier modifier = () =>
            {
                for (int i = listOriginal.Count - 1; i > 0; i--)
                {
                    if (listOriginal[i] % 2 != 0)
                    {
                        listOriginal[i] = listOriginal[i] + 1;
                    }
                }
            };

            modifier();

            foreach (var item in listOriginal)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 50));

            ParameterExpression x = Expression.Parameter(typeof(int), "x");

            var constant1 = Expression.Constant(2);
            var constant2 = Expression.Constant(3);
            var constant3 = Expression.Constant(4);

            var subBody = Expression.Subtract(x, constant2);
            var multBody = Expression.Multiply(constant1, subBody);
            var addBody = Expression.Add(multBody, x);
            var body = Expression.Subtract(addBody, constant3);

            var expression = Expression.Lambda<Func<int, int>>(body, x);

            Console.WriteLine(expression.Body);

            Func<int, int> funcs = expression.Compile();

            Console.WriteLine("Result: " + funcs(4));

            Console.ReadKey();
        }
    }
}
