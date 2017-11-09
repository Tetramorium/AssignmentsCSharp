using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._4.CharFrequency
{
    public class CharCounter
    {
        public char Character { get; set; }
        public int Count { get; set; }

        public CharCounter(char c)
        {
            this.Character = c;
            this.Count = 1;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", Character, Count.ToString());
        }
    }
}
