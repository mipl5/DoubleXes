using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleString
{
    public class DoubleX: X
    {
        private int d;
        public DoubleX(): base() { }

        public new void SetS(string s)
        {
            base.SetS(s);
        }
        public void SetD(int d)
        {
            if (d > 0)
                this.d = d;
            else
                throw new NotImplementedException();
        }
        public int GetD()
        {
            return d;
        }
        public override string ToString()
        {
            SetS(String.Concat(Enumerable.Repeat(GetS(), d)));
            return base.ToString();
        }
    }
}
