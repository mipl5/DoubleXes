using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleString
{
    public class X
    {
        private string s;
        public X() { }
        public void SetS(string s)
        {
            this.s = s;
        }
        public string GetS()
        {
            return s;
        }
        public override string ToString()
        {
            return string.Format("Name: " + s);
        }
    }
}
