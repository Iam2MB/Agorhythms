using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace HomeWork
{
    internal class lesson3_1
    {
        public static void Benchmark()
        {
            BenchmarkRunner.Run<BechmarkClass>();
        }

        public static PointStructDouble[] GenStructArray()
        {
            PointStructDouble[] array = new PointStructDouble[2];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                PointStructDouble psd = new PointStructDouble();
                psd.x = random.Next(1, 100);
                psd.y = random.Next(1, 100);
                array[i] = psd;
            }
            return array;
        }

        public static PointClassDouble[] GenClassArray()
        {
            PointClassDouble[] array = new PointClassDouble[2];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                PointClassDouble pcd = new PointClassDouble();
                pcd.x = random.Next(1, 100);
                pcd.y = random.Next(1, 100);
                array[i] = pcd;
                
            }
            return array;
        }
    }

    public class BechmarkClass
    {
        [Benchmark]
        public void PointDistanceStruct()
        {
            PointStructDouble[] array = lesson3_1.GenStructArray();
            double x = array[1].x - array[0].x;
            double y = array[1].y - array[0].y;
            Console.WriteLine($"X:{x} Y:{y}");
            Console.WriteLine("Result " + Math.Sqrt((x * x) + (y * y)));
        }

        [Benchmark]
        public void PointDistanceClass()
        {
            PointClassDouble[] array = lesson3_1.GenClassArray();
            double x = array[1].x - array[0].x;
            double y = array[1].y - array[0].y;
            Console.WriteLine($"X:{x} Y:{y}");
            Console.WriteLine("Result " + Math.Sqrt((x * x) + (y * y)));
        }
    }

    public class PointClassDouble
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public struct PointStructDouble
    {
        public double x { get; set; }
        public double y { get; set; }
    }
}
