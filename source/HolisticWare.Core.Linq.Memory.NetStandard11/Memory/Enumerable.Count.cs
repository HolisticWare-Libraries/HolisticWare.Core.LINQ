using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static int Count<TSource>(this Memory<TSource> source)
        {
            // Optimisation
            IList list = source as IList;
            if (list != null)
            {
                return list.Count;
            }
            int count = 0;
            foreach (TSource element in source.ToEnumerable())
            {
                count++;
            }
            return count;
        }
    }
}
