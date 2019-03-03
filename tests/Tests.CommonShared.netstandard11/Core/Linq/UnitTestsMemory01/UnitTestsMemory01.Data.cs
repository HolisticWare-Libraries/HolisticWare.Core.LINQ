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
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
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
using System.Linq;

namespace Tests.CommonShared.Core.Linq
{
    public partial class UnitTestsMemory01
    {
        byte[] data_array_byte = //new byte[]
                                {
                                    1, 2, 3, 4, 5,
                                };
        byte[] data_array_odd_result_actual_byte = //new byte[]
                                {
                                    1, 3, 5, 
                                };
        byte[] data_array_even_result_actual_byte = //new byte[]
                                {
                                    2, 4, 
                                };

        int[] data_array_int = //new byte[]
                                {
                                    1, 2, 3, 4, 5,
                                };
        int[] data_array_odd_result_actual_int = //new byte[]
                                {
                                    1, 3, 5, 
                                };
        int[] data_array_even_result_actual_int = //new byte[]
                                {
                                    2, 4, 
                                };

        short[] data_array_short = //new byte[]
                                {
                                    1, 2, 3, 4, 5,
                                };
        short[] data_array_odd_result_actual_short = //new byte[]
                                {
                                    1, 3, 5, 
                                };
        short[] data_array_even_result_actual_short = //new byte[]
                                {
                                    2, 4, 
                                };


        ushort[] data_array_ushort = //new byte[]
                                {
                                    1, 2, 3, 4, 5,
                                };
        ushort[] data_array_odd_result_actual_ushort = //new byte[]
                                {
                                    1, 3, 5, 
                                };
        ushort[] data_array_even_result_actual_ushort = //new byte[]
                                {
                                    2, 4, 
                                };

        uint[] data_array_uint = //new byte[]
                                {
                                    1, 2, 3, 4, 5,
                                };
        uint[] data_array_odd_result_actual_uint = //new byte[]
                                {
                                    1, 3, 5, 
                                };
        uint[] data_array_even_result_actual_uint = //new byte[]
                                {
                                    2, 4, 
                                };

        long[] data_array_long = //new byte[]
                                {
                                    1, 2, 3, 4, 5,
                                };
        long[] data_array_odd_result_actual_long = //new byte[]
                                {
                                    1, 3, 5, 
                                };
        long[] data_array_even_result_actual_long = //new byte[]
                                {
                                    2, 4, 
                                };

        ulong[] data_array_ulong = //new byte[]
                                {
                                    1, 2, 3, 4, 5,
                                };
        ulong[] data_array_odd_result_actual_ulong = //new byte[]
                                {
                                    1, 3, 5, 
                                };
        ulong[] data_array_even_result_actual_ulong = //new byte[]
                                {
                                    2, 4, 
                                };

     }
}
