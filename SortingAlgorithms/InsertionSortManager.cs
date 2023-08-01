using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSortManager<T> : ISortingService<T> where T : IComparable<T>
    {
        public T[] SortArray(T[] array)
        {
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
            return array;
        }
    }
}
