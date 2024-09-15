using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshGenerics
{
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    internal class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }





        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}
