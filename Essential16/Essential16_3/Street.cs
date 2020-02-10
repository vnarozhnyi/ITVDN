using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential16.Essential16_3
{
    class Street : ICloneable
    {
        private string str;

        public Street(string s)
        {
            str = s;
        }

        public string Str
        {
            get { return str; }
        }

        public object Clone()
        {
            return new Street(this.str);
        }
    }
}
