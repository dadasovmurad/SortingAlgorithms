using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public interface ISortingService<T> where T : IComparable<T>
    {
        T[] SortArray(T[] array);
    }
}
