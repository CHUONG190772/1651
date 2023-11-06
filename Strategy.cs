using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien
{
    internal interface Strategy<T>
    {
        public void Add(List<T> list, T item);
        public void Update(List<T> list, int index, T item);
        public void Delete(List<T> list, int index);
    }
}
