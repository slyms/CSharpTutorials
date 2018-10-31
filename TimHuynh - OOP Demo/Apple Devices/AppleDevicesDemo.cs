using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___OOP_Demo.Apple_Devices
{
    class AppleDevicesDemo
    {
        public static void InterfaceExample()
        {
            ISiriEnabled ip = new IPhone();
            GetSpeeches(ip);

            ISiriEnabled aw = new AppleWatch();
            GetSpeeches(aw);

            ISiriEnabled atv = new AppleTV();
            GetSpeeches(atv);
        }

        private static void GetSpeeches(ISiriEnabled device)
        {
            Console.WriteLine(device.GetType());
            StringBuilder sb = new StringBuilder();

            int number = 1;
            foreach(string command in device.GetPopularSpeeches())
            {
                sb.AppendLine(number + ". " + command);
                    number += 1;
            }
            sb.AppendLine("..........");
            Console.WriteLine(sb.ToString());
        }
    }
}
