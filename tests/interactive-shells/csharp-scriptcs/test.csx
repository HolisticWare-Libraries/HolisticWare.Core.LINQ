/*
scriptcs -install BenchmarkDotNet
*/
using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
 
BenchmarkRunner.Run<Test>();
 
[InProcess]
public class Test
{       
    string original1 = "original 1";
    string original2 = "original 2";
    string original3 = "original 3";

    [Benchmark]
    public void Concatenation1()
    {
        string result = $"{original1} {original1} {original1}";
    }
 
    [Benchmark]
    public void Concatenation2()
    {
        string result = original1 + " " + original1 + " " + original1;
    }
}