using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLGR.DataLayer;
using QLGR.Entities;

namespace QLGR.BusinessLayer
{
    class ThayDoiTienNoBLL
    {
        public static void ThayDoiTienNo(ThayDoiTienNo tienNo)
        {
            ThayDoiTienNoDAL.ThayDoiTienNo(tienNo);
        }
    }
}
