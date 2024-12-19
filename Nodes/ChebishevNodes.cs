using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    public class ChebishevNodes : Nodes
    {
        public ChebishevNodes (int a, int b, int n) : base (a, b, n) { }
        public override double this[int i] => 
            0.5 * (A + B) + 0.5 * (B - A) * Math.Cos((2.0*(i+1)-1)/(2*N) * Math.PI);

        public override double GetNode(int i)
        {
            return this[i];
        }
    }
}
