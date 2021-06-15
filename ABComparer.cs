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

            FileObject f1 = (FileObject)x;
            FileObject f2 = (FileObject)y;

            String s1 = f1.getFileName();
            String s2 = f2.getFileName();

            return String.Compare(s1, s2);
        }
    }
}
