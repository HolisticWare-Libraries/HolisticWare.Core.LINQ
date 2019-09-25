using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static List<TSource> ToList<TSource>(this Memory<TSource> source)
        {
            return new List<TSource>(source.ToList());
        }
    }
}
