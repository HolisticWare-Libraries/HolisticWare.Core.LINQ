using System;
using System.Collections;
using System.Collections.Generic;

using Core.LINQ.Memory.Util;

namespace Core.LINQ.Memory
{
    public  static partial class MemoryExtensions
    {
        public static IEnumerable<T> ToEnumerable<T>(this System.Memory<T> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                yield return memory.Span[i];
            }
        }
    }
}
