using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal struct Line
    {
        double B;
        double K;
        public Line(double b, double k) 
        {  
            this.B = b;
            this.K = k;
          
        }

        public double Root()
        {
            return -B / K;
        }
    }
}
