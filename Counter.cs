using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Counter
    {
        private int countValue;
        public int Min { get; set; }
        public int Max { get; set; }
        public int Value
        {
            get { return countValue; }
            set
            {
                if (value < Min || value > Max)
                {
                    throw new Exception();
                }
                else
                {
                    countValue = value;
                }
            }
        }

        public Counter() {
            Min = 0;
            Max = 0xffff;
            countValue = 0;
        }
        
        public Counter(int minimum, int maximum) {
            Min = minimum;
            Max = maximum;
            countValue = minimum;
        }

        public Counter(int minimum, int maximum, int start) {
            Min = minimum;
            Max = maximum;
            countValue = start;
        }

        public static Counter operator ++ (Counter p1) {
            return new Counter(p1.Min, p1.Max, p1.Value++);
        }

        public static Counter operator -- (Counter p1)
        {
            return new Counter(p1.Min, p1.Max, p1.Value--);
        }

        public string currentState() {
            return "Счетчик сейчас в значении " + Convert.ToString(Value, 16);
        }
    }
}
