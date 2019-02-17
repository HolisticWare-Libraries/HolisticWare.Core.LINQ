using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Running;

using System.Text;

namespace Benchmarks
{
    //[DryCoreJob, DryMonoJob, DryClrJob(Platform.X86)]
    //[ClrJob(baseline: true), CoreJob, MonoJob, CoreRtJob]
    //[RPlotExporter, RankColumn]
    [InProcess]
    public class Strings
    {
        string original1 = "original 1";
        string original2 = "original 2";
        string original3 = "original 3";

        StringBuilder sb = new StringBuilder();


        [Benchmark]
        public void Concatenation_Const_Interpolation()
        {
            string result = $"{original1} {original2} {original3}";
        }

        [Benchmark]
        public void Concatenation_Const_Addition()
        {
            string result = original1+ " " + original2 + " " + original3;
        }

        [Benchmark]
        public void Concatenation_Const_Format()
        {
            string result = string.Format("{0} {1} {2}", original1, original2, original3);
        }

        [Benchmark]
        public void Concatenation_Const_StringBuilder()
        {
            sb.Append(original1);
            sb.Append(" ");
            sb.Append(original2);
            sb.Append(" ");
            sb.Append(original3);

            string result = sb.ToString();
        }

        [Benchmark]
        public void Concatenation_Dynamic_Interpolation()
        {
            string result = $"{original1.ToUpper()} {original2.ToUpper()} {original3.ToUpper()}";
        }

        [Benchmark]
        public void Concatenation_Dynamic_Addition()
        {
            string result = original1.ToUpper() + " " + original2.ToUpper() + " " + original3.ToUpper();
        }

        [Benchmark]
        public void Concatenation_Dynamic_Format()
        {
            string result = string.Format("{0} {1} {2}", original1.ToUpper(), original2.ToUpper(), original3.ToUpper());
        }

        [Benchmark]
        public void Concatenation_Dynamic_StringBuilder()
        {
            sb.Append(original1.ToUpper());
            sb.Append(" ");
            sb.Append(original2.ToUpper());
            sb.Append(" ");
            sb.Append(original3.ToUpper());

            string result = sb.ToString();
        }


    }
}