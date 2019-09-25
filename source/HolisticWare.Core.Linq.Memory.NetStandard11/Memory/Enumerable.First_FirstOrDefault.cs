using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static TSource First<TSource>(this Memory<TSource> source)
        {
            foreach (TSource element in source.ToEnumerable())
            {
                return element;
            }
            throw new System.InvalidOperationException("Empty sequence");
        }

        public static TSource FirstOrDefault<TSource>(this Memory<TSource> source)
        {
            foreach (TSource element in source.ToEnumerable())
            {
                return element;
            }
            return default(TSource);
        }
    }
}
