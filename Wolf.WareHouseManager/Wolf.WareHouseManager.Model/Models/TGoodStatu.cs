using System;
using System.Collections.Generic;

namespace Wolf.WareHouseManager.Model.Models
{
    public partial class TGoodStatu
    {
        public int FStatusID { get; set; }
        public string FStatusName { get; set; }
        public string FRemark { get; set; }
        public int FUserID { get; set; }
        public int FStatus { get; set; }
        public System.DateTime FCreateTime { get; set; }
    }
}
