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

        public Pair(TimeOnly pairStart, TimeOnly pairEnd, TimeOnly breakStart, TimeOnly breakEnd, Shift shift)
        {
            this.pairStart = pairStart;
            this.pairEnd = pairEnd;
            this.breakStart = breakStart;
            this.breakEnd = breakEnd;
            this.shift = shift;
        }
    }
}
