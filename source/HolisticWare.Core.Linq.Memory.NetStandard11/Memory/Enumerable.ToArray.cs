using System;
using System.Linq;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static TSource[] ToArray<TSource>(this Memory<TSource> source)
        {
            return source.ToEnumerable().ToArray();
        }
    }
}
