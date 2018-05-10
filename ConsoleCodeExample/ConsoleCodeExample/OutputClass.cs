using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeExample
{
    public enum tOutputLocation
    {
        Screen,
        Database,
        TextFile
    }

    static public class Output
    {
        static public bool Write(string outstring, tOutputLocation outputLocation)
        {
            switch (outputLocation)
            {
                case tOutputLocation.Screen:
                    Console.WriteLine(outstring);
                    return true;
                case tOutputLocation.Database:
                    // add database write here
                    Console.WriteLine("Unimplemented output location: Database, output string: '" + outstring + "'");
                    return false; // failed to write
                case tOutputLocation.TextFile:
                    // add File write here
                    Console.WriteLine("Unimplemented output location: TextFile, output string: '" + outstring + "'");
                    return false; // failed to write
                default:
                    Console.WriteLine("Unsupported output location: " + outputLocation.ToString() + ", output string: '" + outstring + "'");
                    return false; // failed to write
            }
        }
    }
}
