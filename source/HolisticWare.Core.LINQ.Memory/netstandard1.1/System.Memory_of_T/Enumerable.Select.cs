using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<TResult> Select<TSource, TResult>
                                                    (
                                                        this System.Memory<TSource> source,
                                                        Func<TSource, TResult> projection
                                                    )
        {
            //if (source == null)
            //{
            //    throw new ArgumentNullException();
            //}

            return SelectImpl(source, projection);
        }

        private static IEnumerable<TResult> SelectImpl<TSource, TResult>
                                                    (
                                                        this System.Memory<TSource> source,
                                                        Func<TSource, TResult> projection
                                                    )
        {
            foreach (TSource item in source.ToEnumerable())
            {
                yield return projection(item);
            }
        }
    }
}
