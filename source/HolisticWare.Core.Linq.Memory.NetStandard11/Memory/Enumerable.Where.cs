using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<TSource> Where<TSource>
                                                (
                                                    this Memory<TSource> source,
                                                    Func<TSource, bool> predicate
                                                )
        {
            foreach (TSource item in source.ToEnumerable())
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
