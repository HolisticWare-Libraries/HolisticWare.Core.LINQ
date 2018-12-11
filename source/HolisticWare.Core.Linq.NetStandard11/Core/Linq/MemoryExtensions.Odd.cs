using System;
using System.Collections.Generic;

namespace Core.Linq
{
    public static class MemoryExtensionsOdd
    {
        public static IEnumerable<long> Odd(this Memory<byte> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Odd(this Memory<short> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Odd(this Memory<ushort> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Odd(this Memory<int> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Odd(this Memory<uint> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Odd(this Memory<long> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<ulong> Odd(this Memory<ulong> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Odd(this Memory<float> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return (long)memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Odd(this Memory<double> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return (long)memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Odd(this Memory<decimal> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                if (i % 2 != 0)
                //if ((i / 2) * 2 != i)
                //if ((i & 1) != 0)
                //if ((i >> 1) << 1 != i)
                {
                    yield return (long)memory.Span[i];
                }
            }
        }
    }
}