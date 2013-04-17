using System;
using System.Collections.Generic;

namespace Wolf.WareHouseManager.Model.Models
{
    public partial class TUserInfo
    {
        public int FUserID { get; set; }
        public string FUserName { get; set; }
        public string FNickName { get; set; }
        public string FPassword { get; set; }
        public string FTelPhone { get; set; }
        public string FAddress { get; set; }
        public int FRoleID { get; set; }
        public int FStatus { get; set; }
        public System.DateTime FCreateTime { get; set; }
    }
}
