using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static Memory<T> Add<T>(this Memory<T> memory, T item)
        {
            return memory.ToArray().Concat(new T[] { item }).ToArray().AsMemory();
        }

    }
}
