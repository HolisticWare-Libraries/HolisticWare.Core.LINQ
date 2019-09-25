using System;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static byte Sum(this Memory<byte> m)
        {
            Span<byte> s = m.Span;
            byte sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static short Sum(this Memory<short> m)
        {
            Span<short> s = m.Span;
            short sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static ushort Sum(this Memory<ushort> m)
        {
            Span<ushort> s = m.Span;
            ushort sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static int Sum(this Memory<int> m)
        {
            Span<int> s = m.Span;
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static uint Sum(this Memory<uint> m)
        {
            Span<uint> s = m.Span;
            uint sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static long Sum(this Memory<long> m)
        {
            Span<long> s = m.Span;
            long sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static ulong Sum(this Memory<ulong> m)
        {
            Span<ulong> s = m.Span;
            ulong sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static float Sum(this Memory<float> m)
        {
            Span<float> s = m.Span;
            float sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static double Sum(this Memory<double> m)
        {
            Span<double> s = m.Span;
            double sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static decimal Sum(this Memory<decimal> m)
        {
            Span<decimal> s = m.Span;
            decimal sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }
    }
}
