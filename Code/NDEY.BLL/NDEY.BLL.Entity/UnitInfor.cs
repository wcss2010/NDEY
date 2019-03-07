using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NDEY.BLL.Entity
{
    public class UnitInfor
    {
        public string ID { get; set; }

        public string UnitName { get; set; }

        public string UnitType { get; set; }

        public string UnitBankUser { get; set; }

        public string UnitBankName { get; set; }

        public string UnitBankNo { get; set; }

        public int IsUserAdded { get; set; }
    }
}