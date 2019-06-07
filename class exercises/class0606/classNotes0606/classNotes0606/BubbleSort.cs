using System;
using System.Collections.Generic;
using System.Text;

namespace classNotes0606
{
    public class BubbleSort
    {
        public List<int> Sort(List<int> unsorted)
        {
            if (unsorted == null || unsorted.Count <= 1)
            {
                return unsorted;
            }

            for (int i = 0; i < unsorted.Count; i++)
            {
                for (int j = i + 1; j < unsorted.Count; j++)
                {
                    if (unsorted[i] > unsorted[j])
                    {
                        var temp = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = temp;
                    }
                }
            }

            return unsorted;

            //return null;
        }
    }
}
