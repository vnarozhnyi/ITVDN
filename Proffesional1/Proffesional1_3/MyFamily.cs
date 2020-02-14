using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional1.Proffesional1_3
{
    public interface IFamily<T>
    {
        T Name { get; }
        IFamily<T> Parent { get; }
    }

    public class MyFamily<T> : IFamily<T>
    {
        private readonly T name;
        private readonly IFamily<T> parent;

        public T Name { get { return name; } }
        public IFamily<T> Parent { get { return parent; } }

        private MyFamily(T name, IFamily<T> parent)
        {
            this.name = name;
            this.parent = parent;
        }

        public static IFamily<T> CreateList(IEnumerable<T> items)
        {
            IEnumerator<T> iter = items.GetEnumerator();
            return CreateList(iter);
        }

        public static IFamily<T> CreateList(IEnumerator<T> iter)
        {
            return iter.MoveNext() ?
                  new MyFamily<T>(iter.Current, CreateList(iter))
                : new MyFamily<T>(default(T), null);
        }
    }

        public static class CustomIterators
        {
            public static IEnumerable<T> LinkListIterator<T>(this IFamily<T> theList)
            {
                for (IFamily<T> list = theList; list.Parent != null; list = list.Parent)
                    yield return list.Name;
            }
        }
    
}
