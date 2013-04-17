using System;
using System.Collections.Generic;

namespace Wolf.WareHouseManager.Model.Models
{
    public partial class TR_Model_Comp_Role
    {
        public int FRelationID { get; set; }
        public int FRoleID { get; set; }
        public int FModelID { get; set; }
        public int FCompId { get; set; }
        public int FStatus { get; set; }
        public string FRemark { get; set; }
        public System.DateTime FCreateTime { get; set; }
    }
}
