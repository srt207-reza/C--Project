using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoftWare
{
    internal class SaveData
    {
        string[] SourceId;
        Random rand;
        public string User { get; set; }
        public string Password { get; set; }

        public string OnGetSavePerson()
        {
            rand = new Random();
            SourceId = new string[15];
            SourceId[0] = "#GG5DKQ";
            SourceId[1] = "#H6DAP7";
            SourceId[2] = "#Q45DF6";
            SourceId[3] = "#7RT5SY";
            SourceId[4] = "#PDLS45";
            SourceId[5] = "#LVW5RE";
            SourceId[6] = "#UCTJX6";
            SourceId[7] = "#P26O2M";
            SourceId[8] = "#CGLD95";
            SourceId[9] = "#AWG45D";
            SourceId[10] = "#4S55SI";
            SourceId[11] = "#69DV7B";
            SourceId[12] = "#M1XS67";
            SourceId[13] = "#8US2SA";
            SourceId[14] = "#FR7MF5";
            return SourceId[rand.Next(0,15)];
        }

        public string OnGetRandomCode()
        {
            Random rand = new Random();
            string[] str = { "168951", "771342", "311384","138636","316715","781031", "560556", "311566",
                             "541223", "123555", "188764", "988464", "178135", "756600", "126489", "732151",
                             "981652", "123621", "252773", "876123", "789160", "746422", "400246", "313489"};
            return str[rand.Next(0,str.Length)];
        }
        
    }
}
