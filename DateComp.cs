using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGUFS
{
    class DateComp : IComparer
    {
        public int Compare(object x, object y)
        {
            FileObject f1 = (FileObject)x;
            FileObject f2 = (FileObject)y;

            DateTime d1 = f1.getDateAndTime();
            DateTime d2 = f2.getDateAndTime();

            return DateTime.Compare(d1, d2);
        }
    }
}
