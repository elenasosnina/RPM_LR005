using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /* https://docs.google.com/document/d/1QSQdwb3s6IOh4avDr_-vpiYnII_80yUAVL3H_JkLNXQ/edit */

    public class Pair
    {
        private Shift shift;
        public Shift ShiftLink { get { return shift; } set { shift = value; } }

        private TimeOnly pairStart, pairEnd, breakStart, breakEnd;
        public TimeOnly PairStart { get { return pairStart; } set => pairStart = value; }
        public TimeOnly PairEnd { get { return pairEnd; } set => pairEnd = value; }
        public TimeOnly BreakStart { get { return breakStart; } set => breakStart = value; }
        public TimeOnly BreakEnd { get { return breakEnd; } set => breakEnd = value; }

        public Pair(string pairStart, string pairEnd, string breakStart, string breakEnd, Shift shift)
        {
            this.pairStart = TimeOnly.Parse(pairStart);
            this.pairEnd = TimeOnly.Parse(pairEnd);
            this.breakStart = TimeOnly.Parse(breakStart);
            this.breakEnd = TimeOnly.Parse(breakEnd);
            this.shift = shift;
        }
    }
}
