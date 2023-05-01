using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pair
    {
        private Shift shift;
        public Shift ShiftLink { get { return shift; } set { shift = value; } }


        private TimeOnly pairStart, pairEnd, breakStart, breakEnd;
        public TimeOnly PairStart { get { return pairStart; } set => pairStart = value; }
        public TimeOnly PairEnd { get { return pairEnd; } set => pairEnd = value; }
        public TimeOnly BreakStart { get { return breakStart; } set => breakStart = value; }
        public TimeOnly BreakEnd { get { return breakEnd; } set => breakEnd = value; }


        public Pair() : this("00:00:00", "23:59:59") { }
        public Pair(string pairStart, string pairEnd)
            : this(pairStart, pairEnd, "00:00:00", "23:59:59", new Shift()) { }
        public Pair(string pairStart, string pairEnd, string breakStart, string breakEnd, Shift shift)
        {
            this.pairStart = TimeOnly.Parse(pairStart);
            this.pairEnd = TimeOnly.Parse(pairEnd);
            this.breakStart = TimeOnly.Parse(breakStart);
            this.breakEnd = TimeOnly.Parse(breakEnd);
            this.shift = shift;
        }

        //public struct PairStruct
        //{
        //    private TimeOnly pairStart, pairEnd, breakStart, breakEnd;
        //    private Shift shift;

        //    public PairStruct(TimeOnly pairS, TimeOnly pairE, TimeOnly breakS, TimeOnly breakE, Shift shift)
        //    {
        //        pairStart = pairS;
        //        pairEnd = pairE;
        //        breakStart = breakS;
        //        breakEnd = breakE;
        //        this.shift = shift;
        //    }
        //}
    }
}
