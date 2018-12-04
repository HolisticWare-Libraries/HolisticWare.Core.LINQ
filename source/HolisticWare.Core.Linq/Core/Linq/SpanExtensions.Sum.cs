using System;

namespace Core.Linq
{
    public static class SpanExtensionsSum
    {
        public static double Sum(this Span<byte> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Sum(this Span<short> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Sum(this Span<ushort> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Sum(this Span<int> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Sum(this Span<uint> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Sum(this Span<long> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Sum(this Span<ulong> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Sum(this Span<float> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Sum(this Span<double> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static decimal Sum(this Span<decimal> span)
        {
            decimal sum = 0.0M;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

    }
}
