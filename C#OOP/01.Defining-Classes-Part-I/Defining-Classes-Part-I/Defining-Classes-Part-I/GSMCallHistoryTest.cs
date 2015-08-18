using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{
    public class GSMCallHistoryTest
    {
        public static void TestCalls()
        {
            GSM mySiemens = new GSM("M35", "Siemens");
            mySiemens.AddCall(new Call(DateTime.Now, "+359 88 762 96 96", 72));
            mySiemens.AddCall(new Call(DateTime.Today, "+359 99 923 33 33", 245));
            mySiemens.AddCall(new Call(DateTime.UtcNow, "+359 87 244 67 88", 456));

            PrintCallHistory(mySiemens);
            Console.WriteLine("Total call price: {0:0.00}", mySiemens.TotalCallPrice(0.37M));
            mySiemens.DeleteCall(LongestCallIndex(mySiemens) + 1);
            Console.WriteLine("Modified total call price: {0:0.00}", mySiemens.TotalCallPrice(0.37M));
            mySiemens.ClearCallHistory();
            PrintCallHistory(mySiemens);
        }

        public static void PrintCallHistory(GSM gsm)
        {
            Console.WriteLine("-----------------------------");
            foreach (var item in gsm.CallHistory)
            {
                Console.WriteLine("Time: {0}", item.DateAndTime);
                Console.WriteLine("Number: {0}", item.DialedNumber);
                Console.WriteLine("Duration: {0} sec", item.Duration);
                Console.WriteLine("-----------------------------");
            }
        }

        public static int LongestCallIndex(GSM gsm)
        {
            int maxDuration = 0;
            int longestCallIndex = 0;
            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                if (gsm.CallHistory[i].Duration > maxDuration)
                {
                    maxDuration = gsm.CallHistory[i].Duration;
                    longestCallIndex = i;
                }
            }
            return longestCallIndex;
        }
    }
}
