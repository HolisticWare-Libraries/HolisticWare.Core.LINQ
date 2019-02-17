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

        [Benchmark]
        public void Concatenation_Interpolation()
        {
            string result = $"{original1} {original1} {original1}";
        }
    
        [Benchmark]
        public void Concatenation_Addition()
        {
            string result = original1 + " " + original2 + " " + original3;
        }
    }
}