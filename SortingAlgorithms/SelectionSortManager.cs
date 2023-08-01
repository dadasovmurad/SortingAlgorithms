using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSortManager<T> : ISortingService<T> where T : IComparable<T>
    {
        public T[] SortArray(T[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    T temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
            return array;
        }
    }
}
