using System;
using System.Reflection;
using System.IO;
using System.Resources;

namespace TestCSharp6
{
    class Point
    {
        public int X { get; }

        public int Y { get; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int Area() => X * Y;

        public override string ToString() => $"[Point: X={X}, Y={Y}]";
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var p = new Point(3, 4);
            Console.WriteLine(p + " area: " + p.Area());

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "TestCSharp6.data.txt";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                Console.WriteLine(result);
            }

            Console.WriteLine(res.ResourceManager.GetString("NotesLabel"));
        }
    }
}
