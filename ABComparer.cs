using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGUFS
{
    class ABComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            String[] a = (String[])x;
            String[] b = (String[])y;
            return String.Compare(a[0], b[0]);
        }
    }
}
