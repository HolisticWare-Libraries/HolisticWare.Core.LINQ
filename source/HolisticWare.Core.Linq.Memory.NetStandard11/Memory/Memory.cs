using System;
using System.Collections;
using System.Collections.Generic;

using Core.Linq.Memory.Util;

namespace Core.Linq.Memory
{
    public  static partial class MemoryExtensions
    {
        public static IEnumerable<T> ToEnumerable<T>(this Memory<T> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                yield return memory.Span[i];
            }
        }
    }
}
