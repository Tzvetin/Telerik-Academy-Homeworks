using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{
    public class DefiningClassesMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********");
            Console.WriteLine("GSM Test");
            Console.WriteLine("********");
            GSMTest.Test();
            Console.WriteLine("*****************");
            Console.WriteLine("Call History Test");
            Console.WriteLine("*****************");
            GSMCallHistoryTest.TestCalls();
        }
    }
}
