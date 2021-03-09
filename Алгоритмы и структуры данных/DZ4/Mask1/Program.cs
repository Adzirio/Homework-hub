using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Mask1
{
    public class Test
    {
        public Random rnd = new Random();
        public HashSet<string> hashSet = new HashSet<string>(100);
        public string[] testArray = new string[10000];
        public void AddValue()
        {
            for (int i = 0; i < testArray.Length; i++)
            {
                string set = (rnd.Next(99999999, 1000000000)).ToString();
                testArray[i] = set;
                hashSet.Add(set);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BenchmarkClass
    {
        [Benchmark]
        public void TestOfHashSet()
        {
            var classTest = new Test();
            classTest.AddValue();
            string test = classTest.testArray[7499];
            var result = classTest.hashSet.Contains(test);
            Console.WriteLine(result);
        }
        [Benchmark]
        public void TestOfArray()
        {
            var classTest = new Test();
            classTest.AddValue();
            string test = classTest.testArray[7499];
            for (int i = 0; i < classTest.testArray.Length; i++)
            {
                string user = classTest.testArray[i];
                if (test == user)
                {
                    Console.WriteLine(user);
                    return;
                }
            }
        }
    }
}


