using System;
using System.Collections.Generic;

namespace Wolf.WareHouseManager.Model.Models
{
    public partial class TGood
    {
        public int FGoodID { get; set; }
        public string FGoodName { get; set; }
        public bool FIsFitting { get; set; }
        public string FRemark { get; set; }
        public int FUserID { get; set; }
        public int FStatus { get; set; }
        public System.DateTime FCreateTime { get; set; }
    }
}
