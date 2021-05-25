using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_Pg369_DuckApp
{
    class DuckCompareByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
                return -1;
            else if (x.Kind > y.Kind)
                return 1;
            else
                return 0;
        }
    }
}
