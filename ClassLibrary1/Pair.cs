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
        public Shift ShiftLink { get; }
        public TimeOnly PairStart { get; }
        public TimeOnly PairEnd { get; }
        public TimeOnly BreakStart { get; }
        public TimeOnly BreakEnd { get; }

        public Pair(TimeOnly pairStart, TimeOnly pairEnd, TimeOnly breakStart, TimeOnly breakEnd, Shift shift)
        {
            PairStart = pairStart;
            PairEnd = pairEnd;
            BreakStart = breakStart;
            BreakEnd = breakEnd;
            this.ShiftLink = shift;
        }
    }
}
