#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Text;
using Core.Linq;
using System.Collections;

namespace Tests.CommonShared.Core.Linq
{
    public partial class UnitTests01_Memory_Odd
    {
        byte[] array_byte = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        long[] actual_long = new long[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        ulong[] actual_ulong = new ulong[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };


        [Benchmark()]
        public IEnumerable<long> Memory_Byte_Odd(Memory<byte> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_Byte_Odd_Test()
        {
            IEnumerable<long> expected_odd_byte = Memory_Byte_Odd(new Memory<byte>(array_byte));

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_odd_byte, actual_long);
#elif XUNIT
            Assert.Equal(expected_odd_byte, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_odd_byte, actual_long);
#endif

            return;
        }

        short[] array_short = new short[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<long> Memory_Short_Odd(Memory<short> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_Short_Odd_Test()
        {
            IEnumerable<long> expected_odd_short = Memory_Short_Odd(new Memory<short>(array_short));

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_odd_short, actual_long);
#elif XUNIT
            Assert.Equal(expected_odd_short, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_odd_short, actual_long);
#endif

            return;
        }

        ushort[] array_ushort = new ushort[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<long> Memory_UShort_Odd(Memory<ushort> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_UShort_Odd_Test()
        {
            IEnumerable<long> expected_odd_ushort = Memory_UShort_Odd(new Memory<ushort>(array_ushort));

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_odd_ushort, actual_long);
#elif XUNIT
            Assert.Equal(expected_odd_ushort, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_odd_ushort, actual_long);
#endif

            return;
        }

        int[] array_int = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<long> Memory_Int_Odd(Memory<int> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_Int_Odd_Test()
        {
            IEnumerable<long> expected_odd_int = Memory_Int_Odd(new Memory<int>(array_int));

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_odd_int, actual_long);
#elif XUNIT
            Assert.Equal(expected_odd_int, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_odd_int, actual_long);
#endif

            return;
        }

        uint[] array_uint = new uint[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<long> Memory_UInt_Odd(Memory<uint> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_UInt_Odd_Test()
        {
            IEnumerable<long> expected_odd_uint = Memory_UInt_Odd(new Memory<uint>(array_uint));

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_odd_uint, actual_long);
#elif XUNIT
            Assert.Equal(expected_odd_uint, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_odd_uint, actual_long);  
#endif

            return;
        }

        long[] array_long = new long[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<long> Memory_Long_Odd(Memory<long> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_Long_Odd_Test()
        {
            IEnumerable<long> expected_odd_long = Memory_Long_Odd(new Memory<long>(array_long));

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_odd_long, actual_long);
#elif XUNIT
            Assert.Equal(expected_odd_long, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_odd_long, actual_long);
#endif

            return;
        }

        ulong[] array_ulong = new ulong[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<ulong> Memory_ULong_Odd(Memory<ulong> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_ULong_Odd_Test()
        {
            IEnumerable<ulong> expected_odd_ulong = Memory_ULong_Odd(array_ulong.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((ulong[])expected_odd_ulong, actual_ulong);
#elif XUNIT
            Assert.Equal(expected_odd_ulong, actual_ulong);
#elif MSTEST
            CollectionAssert.AreEqual((ulong[])expected_odd_ulong, actual_ulong);
#endif

            return;
        }

        float[] array_float = new float[] { 0F, 1F, 2F, 3F, 4F, 5F, 6F, 7F, 8F, 9F, 10F, 11F, 12F, 13F, 14F, 15F, 16F, 17F, 18F, 19F, 20F };

        [Benchmark()]
        public IEnumerable<long> Memory_Float_Odd(Memory<float> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_Float_Odd_Test()
        {
            IEnumerable<long> expected_odd_float = Memory_Float_Odd(new Memory<float>(array_float));

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_odd_float, actual_long);
#elif XUNIT
            Assert.Equal(expected_odd_float, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_odd_float, actual_long);
#endif

            return;
        }

        double[] array_double = new double[] { 0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0, 11.0, 12.0, 13.0, 14.0, 15.0, 16.0, 17.0, 18.0, 19.0, 20.0 };

        [Benchmark()]
        public IEnumerable<long> Memory_Double_Odd(Memory<double> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_Double_Odd_Test()
        {
            IEnumerable<long> expected_odd_double = Memory_Double_Odd(new Memory<double>(array_double));

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_odd_double, actual_long);
#elif XUNIT
            Assert.Equal(expected_odd_double, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_odd_double, actual_long);
#endif

            return;
        }

        decimal[] array_decimal = new decimal[] { 0.0M, 1.0M, 2.0M, 3.0M, 4.0M, 5.0M, 6.0M, 7.0M, 8.0M, 9.0M, 10.0M, 11.0M, 12.0M, 13.0M, 14.0M, 15.0M, 16.0M, 17.0M, 18.0M, 19.0M, 20.0M };

        [Benchmark()]
        public IEnumerable<long> Memory_Decimal_Odd(Memory<decimal> memory)
        {
            return memory.Odd();
        }

        [Test()]
        public void Memory_Decimal_Odd_Test()
        {
            IEnumerable<long> expected_odd_decimal = Memory_Decimal_Odd(new Memory<decimal>(array_decimal));

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_odd_decimal, actual_long);
#elif XUNIT
            Assert.Equal(expected_odd_decimal, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_odd_decimal, actual_long);
#endif

            return;
        }
    }
}