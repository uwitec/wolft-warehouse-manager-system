using System;
using System.Collections.Generic;

namespace Wolf.WareHouseManager.Model.Models
{
    public partial class TCustomer
    {
        public int FCustomerID { get; set; }
        public string FCustomerName { get; set; }
        public string FArtificialPerson { get; set; }
        public string FLicenceNo { get; set; }
        public string FTelPerson { get; set; }
        public string FAddress { get; set; }
        public bool FIsSupplier { get; set; }
        public string FRemark { get; set; }
        public int FUserID { get; set; }
        public int FStatus { get; set; }
        public System.DateTime FCreateTime { get; set; }
    }
}
