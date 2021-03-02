using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Mask1
{
    public class PointClass
    {
        public int X;
        public int Y;
    }
    public struct PointStruct
    {
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

            // После проверки на моем устроёстве были полученны следующие данные.
            //
            // |                 Method |     Mean |    Error |   StdDev |
            // |------------------------|---------:|---------:|---------:|
            // |         TestFloatClass | 11.06 ns | 0.251 ns | 0.235 ns |
            // |        TestFloatStruct | 18.69 ns | 0.034 ns | 0.031 ns |
            // |        TestDouleStruct | 20.86 ns | 0.128 ns | 0.113 ns |
            // |  TestFloatStructNoMath | 14.21 ns | 0.047 ns | 0.044 ns |
        }
    }
    public class BenchmarkClass
    {
        public static float PointDistanceShortCF(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static float PointDistanceShortSF(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static double PointDistanceShortSD(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public static float PointDistanceShortSFNM(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return ((x * x) + (y * y));
        }
        [Benchmark]
        public void TestFloatClass()
        {
            var class1 = new PointClass { X = 10, Y = 20 };
            var class2 = new PointClass { X = 30, Y = 50 };
            PointDistanceShortCF(class1, class2);
        }
        [Benchmark]
        public void TestFloatStruct()
        {
            var struct1 = new PointStruct { X = 10, Y = 20 };
            var struct2 = new PointStruct { X = 30, Y = 50 };
            PointDistanceShortSF(struct1, struct2);
        }
        [Benchmark]
        public void TestDouleStruct()
        {
            var struct1 = new PointStruct { X = 10, Y = 20 };
            var struct2 = new PointStruct { X = 30, Y = 50 };
            PointDistanceShortSD(struct1, struct2);
        }
        [Benchmark]
        public void TestFloatStructNoMath()
        {
            var struct1 = new PointStruct { X = 10, Y = 20 };
            var struct2 = new PointStruct { X = 30, Y = 50 };
            PointDistanceShortSFNM(struct1, struct2);
        }
    }
}
