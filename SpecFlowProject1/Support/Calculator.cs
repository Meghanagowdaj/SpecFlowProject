using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support
{
    public class Calculator
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
        public int Add()
        {
            int res;
            res = Fnum + Snum;
            return res;
        }
    }
}
