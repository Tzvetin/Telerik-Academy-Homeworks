using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{
    public class GSMTest
    {
        public static void Test()
        {
            GSM[] gsmArray = new GSM[3];
            gsmArray[0] = new GSM("Lumia 926", "Nokia");
            gsmArray[1] = new GSM("Galaxy S4", "Samsung", 299.99, "John Smith", new Battery("2600 mAh"), new Display());
            gsmArray[2] = new GSM("Windows Phone 8", "HTC");

            gsmArray[0].Owner = "Ivan Petrov";
            gsmArray[2].Owner = "Jack Daniels";
            gsmArray[2].Price = 399.99;
            Battery htcBattery = new Battery("1800 mAh", 370, 17, BatteryType.LiIon);
            Display htcDisplay = new Display(720, 16000000);
            gsmArray[2].GSMBattery = htcBattery;
            gsmArray[2].GSMDisplay = htcDisplay;

            foreach (var item in gsmArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(GSM.IPhone4S.ToString());
            Console.WriteLine("-----------------------------");
        }
    }
}
