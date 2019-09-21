using System;
using System.Linq;

using Core.Linq.Util;

namespace Core.Linq
{
    public static partial class MemoryExtensions
    {
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>
                                                                (
                                                                    this Memory<TSource> source,
                                                                    Func<TSource, TKey> keySelector
                                                                ) {
            return new IOrderedEnumerable<TSource>
                                        (
                                            source,
                                            ProjectionComparer.Create(keySelector)
                                        );
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>
                                                                (
                                                                    this Memory<TSource> source,
                                                                    Func<TSource, TKey> keySelector
                                                                )
            {
            return new OrderedEnumerable<TSource>
                                        (
                                            source,
                                            new ReverseComparer<TSource>(ProjectionComparer.Create(keySelector))
                                        );
        }
    }
}
