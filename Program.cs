using System;
using System.Text.RegularExpressions;

namespace GcodeTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var line = Console.ReadLine();
            Regex gcode = new Regex("[GXYZ][-+]?[0-9]*\\.?[0-9]*", RegexOptions.IgnoreCase);

            MatchCollection m = gcode.Matches(line);

            double x, y, z, g;
            foreach (Match n in m)
            {
                if (n.Value.StartsWith("G"))
                {
                    g = Convert.ToDouble(n.Value.Remove(0, 1));
                    Console.WriteLine("Command =  " + n.Value);
                    Console.WriteLine("value =  " + g);

                    switch (n.Value.ToUpper())
                    {
                        case "G00":
                            //
                            break;

                        case "G01":
                            //
                            break;

                        case "G02":
                            //
                            break;

                        case "G03":
                            //
                            break;

                        case "G28":
                            break;

                        case "G90":
                            //
                            break;

                        case "G91":

                            Console.Out.WriteLine("finally yes");
                            break;
                    }
                }

                if (n.Value.StartsWith("X"))
                {
                    x = Convert.ToDouble(n.Value.Remove(0, 1));
                    Console.WriteLine("Command =  " + n.Value);
                }

                if (n.Value.StartsWith("Y"))
                {
                    y = Convert.ToDouble(n.Value.Remove(0, 1));
                    Console.WriteLine("Command =  " + n.Value);
                }

                if (n.Value.StartsWith("Z"))
                {
                    z = Convert.ToDouble(n.Value.Remove(0, 1));
                    Console.WriteLine("Command =  " + n.Value);
                }
            }
        }
    }
}