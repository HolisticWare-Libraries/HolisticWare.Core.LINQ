#! "netcoreapp2.0"
#r "nuget:BenchmarkDotNet, 0.11.4"

/*
//#!/usr/bin/env dotnet-script
https://github.com/filipw/dotnet-script
https://www.strathweb.com/2017/12/c-repl-for-net-core-2-0-and-load-support-from-nuget-0-16-dotnet-script-is-out/
https://www.strathweb.com/2018/03/lightweight-net-core-benchmarking-with-benchmarkdotnet-and-dotnet-script/


dotnet script init sort.csx
dotnet script sort.csx -c Release

nuget dependencies!

Options:

    dotnet script


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