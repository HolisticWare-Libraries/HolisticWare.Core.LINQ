using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class MemoryExtensions
    {
        public static Memory<T> Empty<T>(this Memory<T> memory)
        {
            return Memory<T>.Empty;
        }
    }
}
