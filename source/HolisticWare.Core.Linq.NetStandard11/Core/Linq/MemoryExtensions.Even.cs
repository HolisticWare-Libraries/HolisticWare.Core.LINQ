using System;
using System.Collections.Generic;

namespace Core.Linq
{
    public static class MemoryExtensionsEven
    {
        public static IEnumerable<long> Even(this Memory<byte> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Even(this Memory<short> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Even(this Memory<ushort> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Even(this Memory<int> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<uint> Even(this Memory<uint> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Even(this Memory<long> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<ulong> Even(this Memory<ulong> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Even(this Memory<float> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return (long)memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Even(this Memory<double> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return (long)memory.Span[i];
                }
            }
        }

        public static IEnumerable<long> Even(this Memory<decimal> memory)
        {
            int length = memory.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                //if ((i / 2) * 2 == i)
                //if ((i & 1) == 0)
                //if ((i >> 1) << 1 == i)
                {
                    yield return (long)memory.Span[i];
                }
            }
        }
    }
}
