using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___OOP_Demo.Apple_Devices
{
    //Interface implementation
    class IPhone : ISiriEnabled
    {
        //Implementation details for GetPopularSpeaches()
        public string[] GetPopularSpeeches()
        {
            return new string[]
            {
                "Call Jennifer",
                "How far away is Sydney?",
                "What's the Apple stock at?",
                "Play 'Shape of You', by Ed Sheeran",
                "Show photos of my Japan trip"
            };
        }
    }
}
