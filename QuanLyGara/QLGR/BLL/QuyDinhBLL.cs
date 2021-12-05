using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace QLGR.BusinessLayer
{
    class QuyDinhBLL
    {
        public static void ThayDoiQuyDinh(QLGR.Entities.QuyDinh quyDinh)
        {
            DataLayer.QuyDinhDAL.ThayDoiQuyDinh(quyDinh);
        }

        public static Entities.QuyDinh GetQuyDinh()
        {
            return DataLayer.QuyDinhDAL.GetQuyDinh();
        }
    }
}
