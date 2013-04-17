using System;
using System.Collections.Generic;

namespace Wolf.WareHouseManager.Model.Models
{
    public partial class TPrice
    {
        public int FPriceID { get; set; }
        public int FGoodID { get; set; }
        public decimal FPrice { get; set; }
        public int FUserID { get; set; }
        public int FStatus { get; set; }
        public System.DateTime FPriceTime { get; set; }
        public string FRemark { get; set; }
        public System.DateTime FCreateTime { get; set; }
    }
}
