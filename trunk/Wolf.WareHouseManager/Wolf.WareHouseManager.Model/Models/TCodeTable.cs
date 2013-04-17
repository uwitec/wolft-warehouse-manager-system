using System;
using System.Collections.Generic;

namespace Wolf.WareHouseManager.Model.Models
{
    public partial class TCodeTable
    {
        public int FID { get; set; }
        public string FName { get; set; }
        public int FStatus { get; set; }
        public string FRemark { get; set; }
        public int FIsTable { get; set; }
        public System.DateTime FCreateTime { get; set; }
    }
}
