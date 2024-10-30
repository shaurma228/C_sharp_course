using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task1
{
    class Screen
    {
        protected int resH, resV, size; //resolution horisontal, resolution vertical, size (inch)

        public Screen(int a, int b, int c)
        {
            this.resH = a;
            this.resV = b;
            this.size = c;
        }

        public int MaxLastNum()
        {
            int last_a = Math.Abs(resH) % 10;
            int last_b = Math.Abs(resV) % 10;
            int last_c = Math.Abs(size) % 10;
            return Math.Max(last_a, Math.Max(last_b, last_c));
        }

        public override string ToString()
        {
            return $"Resolution: {resH}x{resV}, Size: {size} inch";
        }

        public int A
        {
            get { return resH; }
        }

        public int B
        {
            get { return resV; }
        }

        public int C
        {
            get { return size; }
        }
    }
}
