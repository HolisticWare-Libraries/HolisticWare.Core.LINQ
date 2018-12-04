using System;

namespace Core.Linq
{
    public static class SpanExtensionsMin
    {
        public static double Min(this Span<byte> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Min(this Span<short> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Min(this Span<ushort> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Min(this Span<int> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Min(this Span<uint> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Min(this Span<long> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Min(this Span<ulong> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Min(this Span<float> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Min(this Span<double> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static decimal Min(this Span<decimal> span)
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
