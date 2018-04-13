using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class Sort
    {
        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <param name="data">data</param>
        public static void SelectSort(IList<int> data)
        {
           
            for (int i = 0; i < data.Count - 1; i++)
            {
                int min = i;
                int temp = data[i];
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (data[j] < temp)
                    {
                        min = j;
                        temp = data[j];
                    }
                }
                if (min != i)
                    Swap(data, min, i);
            }
        }

        /// <summary>
        /// Swap data
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(IList<int> data, int a, int b)
        {
            int temp = data[a];
            data[a] = data[b];
            data[b] = temp;
        }
    }

}
