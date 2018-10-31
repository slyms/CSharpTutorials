using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___OOP_Demo.Apple_Devices
{
    //Interface implementation
    class AppleWatch : ISiriEnabled
    {
        //Implementation details for GetPopularSpeaches()
        public string[] GetPopularSpeeches()
        {
            return new string[]
            {
                "What time is it?",
                "How many days until Christmas?",
                "Text Andy 'Hey, where are you?'",
                "What's my heart rate?"
            };
        }
    }
}
