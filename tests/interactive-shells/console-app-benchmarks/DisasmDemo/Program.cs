using System.Runtime.CompilerServices;
using System.Linq;

using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Toolchains.InProcess;

namespace Benchmarks
{
    [Config(typeof(Config))]
    //[Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class IntroInProcess
    {
    }

    internal class Config : ManualConfig
    {
        public Config()
        {
            Add
                (
                    Job.MediumRun
                            .WithLaunchCount(1)
                            .WithId("OutOfProc")
                );

            Add(DefaultConfig.Instance.GetExporters().ToArray());
            Add(DefaultConfig.Instance.GetLoggers().ToArray());
            Add(DefaultConfig.Instance.GetColumnProviders().ToArray());
        }
    }
    
    class Program
    {
        static void Main() => BenchmarkRunner.Run<Strings>(new Config());
    }
}