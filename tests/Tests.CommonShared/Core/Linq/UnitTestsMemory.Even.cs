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
    public partial class UnitTests01_Memory_Even
    {
        byte[] array_byte = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        long[] actual_long = new long[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        ulong[] actual_ulong = new ulong[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        uint[] actual_uint = new uint[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };


        [Benchmark()]
        public IEnumerable<long> Memory_Byte_Even(Memory<byte> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Byte_Even_Test()
        {
            IEnumerable<long> expected_even_byte = Memory_Byte_Even(array_byte.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual(expected_even_byte, actual_long);
#elif XUNIT
            Assert.Equal(expected_even_byte, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_even_byte, actual_long);
#endif

            return;
        }

        short[] array_short = new short[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<long> Memory_Short_Even(Memory<short> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Short_Even_Test()
        {
            IEnumerable<long> expected_even_short = Memory_Short_Even(array_short.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((long[])expected_even_short, actual_long);
#elif XUNIT
            Assert.Equal(expected_even_short, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_even_short, actual_long);
#endif

            return;
        }

        ushort[] array_ushort = new ushort[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<long> Memory_UShort_Even(Memory<ushort> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_UShort_Even_Test()
        {
            IEnumerable<long> expected_even_ushort = Memory_UShort_Even(array_ushort.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((long[])expected_even_ushort, actual_long);
#elif XUNIT
            Assert.Equal(expected_even_ushort, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_even_ushort, actual_long);
#endif

            return;
        }

        int[] array_int = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<long> Memory_Int_Even(Memory<int> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Int_Even_Test()
        {
            IEnumerable<long> expected_even_int = Memory_Int_Even(array_int.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((long[])expected_even_int, actual_long);
#elif XUNIT
            Assert.Equal(expected_even_int, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_even_int, actual_long);
#endif

            return;
        }

        uint[] array_uint = new uint[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<uint> Memory_UInt_Even(Memory<uint> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_UInt_Even_Test()
        {
            IEnumerable<uint> expected_even_uint = Memory_UInt_Even(array_uint.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((uint[])expected_even_uint, actual_uint);
#elif XUNIT
            Assert.Equal(expected_even_uint, actual_uint);
#elif MSTEST
            CollectionAssert.AreEqual((uint[])expected_even_uint, actual_uint);  
#endif

            return;
        }

        long[] array_long = new long[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<long> Memory_Long_Even(Memory<long> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Long_Even_Test()
        {
            IEnumerable<long> expected_even_long = Memory_Long_Even(array_long.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((long[])expected_even_long, actual_long);
#elif XUNIT
            Assert.Equal(expected_even_long, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_even_long, actual_long);
#endif

            return;
        }

        ulong[] array_ulong = new ulong[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [Benchmark()]
        public IEnumerable<ulong> Memory_ULong_Even(Memory<ulong> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_ULong_Even_Test()
        {
            IEnumerable<ulong> expected_even_ulong = Memory_ULong_Even(array_ulong.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((ulong[])expected_even_ulong, actual_ulong);
#elif XUNIT
            Assert.Equal(expected_even_ulong, actual_ulong);
#elif MSTEST
            CollectionAssert.AreEqual((ulong[])expected_even_ulong, actual_ulong);
#endif

            return;
        }

        float[] array_float = new float[] { 0F, 1F, 2F, 3F, 4F, 5F, 6F, 7F, 8F, 9F, 10F, 11F, 12F, 13F, 14F, 15F, 16F, 17F, 18F, 19F, 20F };

        [Benchmark()]
        public IEnumerable<long> Memory_Float_Even(Memory<float> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Float_Even_Test()
        {
            IEnumerable<long> expected_even_float = Memory_Float_Even(array_float.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((long[])expected_even_float, actual_long);
#elif XUNIT
            Assert.Equal(expected_even_float, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_even_float, actual_long);
#endif

            return;
        }

        double[] array_double = new double[] { 0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0, 11.0, 12.0, 13.0, 14.0, 15.0, 16.0, 17.0, 18.0, 19.0, 20.0 };

        [Benchmark()]
        public IEnumerable<long> Memory_Double_Even(Memory<double> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Double_Even_Test()
        {
            IEnumerable<long> expected_even_double = Memory_Double_Even(array_double.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((long[])expected_even_double, actual_long);
#elif XUNIT
            Assert.Equal(expected_even_double, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_even_double, actual_long);
#endif

            return;
        }

        decimal[] array_decimal = new decimal[] { 0.0M, 1.0M, 2.0M, 3.0M, 4.0M, 5.0M, 6.0M, 7.0M, 8.0M, 9.0M, 10.0M, 11.0M, 12.0M, 13.0M, 14.0M, 15.0M, 16.0M, 17.0M, 18.0M, 19.0M, 20.0M };

        [Benchmark()]
        public IEnumerable<long> Memory_Decimal_Even(Memory<decimal> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Decimal_Even_Test()
        {
            IEnumerable<long> expected_even_decimal = Memory_Decimal_Even(array_decimal.AsMemory());

            // Assert
#if NUNIT
            CollectionAssert.AreEqual((long[])expected_even_decimal, actual_long);
#elif XUNIT
            Assert.Equal(expected_even_decimal, actual_long);
#elif MSTEST
            CollectionAssert.AreEqual((long[])expected_even_decimal, actual_long);
#endif

            return;
        }
    }
}
