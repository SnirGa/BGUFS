using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGUFS
{
    class SizeComp : IComparer
    {
        public int Compare(object x, object y)
        {
            FileObject f1 = (FileObject)x;
            FileObject f2 = (FileObject)y;

            int i1 = f1.getLength();
            int i2 = f2.getLength();

            return i1.CompareTo(i2);
        }
    }
}
