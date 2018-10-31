using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___OOP_Demo.Apple_Devices
{
    //Interface implementation
    class AppleTV : ISiriEnabled
    {
        //Implementation details for GetPopularSpeaches()
        public string[] GetPopularSpeeches()
        {
            return new string[]
            {
                "Open HBO now",
                "Play the latest episode of Game of Thrones",
                "Open Minecraft"
            };
        }
    }
}
