using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    public abstract class Nodes
    {
        private int _a;
        private int _b;
        private int _n;

        public int A => _a;
        public int B => _b;
        public int N
        {
            get => _n;
            set => _n = value >= 1 ? value: 1;
        }

        public Nodes(int a, int b, int n)
        {
            N = n;
            SetBoundaries(a, b);
        }

        public void SetBoundaries(int a, int b)
        {
            _a = Math.Min(a, b);
            _b = Math.Max(a, b);
        }

        public abstract double GetNode(int i);
    }
}
