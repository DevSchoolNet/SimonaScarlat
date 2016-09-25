using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;
using Newtonsoft.Json.Linq;
using System.IO;

namespace NewFeaturesC
{
    public class Point
    {
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; }
        public int Y { get; }
        public double Distance => Sqrt(X * X + Y * Y);

        public override string ToString() => string.Format("{0} {1} {2}", X, Y, Distance);

        public string Sum() =>  $"Sum: {X} + {Y} = {X+Y}";


        public static async Task LogExceptionAsync(string message, Exception exception)
        {
            using (var logFile = File.AppendText("exceptionLog.log"))
            {
                await logFile.WriteLineAsync($"{message} :: {exception}");
            }
        }

      

        public static JArray ToJson(IEnumerable<Point> points)
        {
            var result = new JArray();
            try
            {
                foreach (var point in points)
                {
                    try
                    {
                        result.Add(new JObject
                        {
                            [nameof(X)] = point?.X,
                            [nameof(Y)] = point?.Y,
                            [nameof(Distance)] = point?.Distance

                        });
                    }catch(Exception ex) when (point == null)
                    {
                        LogExceptionAsync("Something wrong",ex).Wait();
                        WriteLine(ex.ToString());
                    }
                }
            }catch(Exception e) when (points == null)
            {
                LogExceptionAsync("Something wrong", e).Wait();
                WriteLine(e.ToString());
            }
            return result;
        }
        
    }
}
