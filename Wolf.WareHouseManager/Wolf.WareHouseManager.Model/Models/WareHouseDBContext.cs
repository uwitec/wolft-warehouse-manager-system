using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Wolf.WareHouseManager.Model.Models.Mapping;

namespace Wolf.WareHouseManager.Model.Models
{
    public partial class WareHouseDBContext : DbContext
    {
        static WareHouseDBContext()
        {
            Database.SetInitializer<WareHouseDBContext>(null);
        }

        public WareHouseDBContext()
            : base("Name=WareHouseDBContext")
        {
        }

        public DbSet<TCodeTable> TCodeTables { get; set; }
        public DbSet<TCustomer> TCustomers { get; set; }
        public DbSet<TGood> TGoods { get; set; }
        public DbSet<TGoodStatu> TGoodStatus { get; set; }
        public DbSet<TPrice> TPrices { get; set; }
        public DbSet<TR_Model_Comp_Role> TR_Model_Comp_Role { get; set; }
        public DbSet<TUserInfo> TUserInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TCodeTableMap());
            modelBuilder.Configurations.Add(new TCustomerMap());
            modelBuilder.Configurations.Add(new TGoodMap());
            modelBuilder.Configurations.Add(new TGoodStatuMap());
            modelBuilder.Configurations.Add(new TPriceMap());
            modelBuilder.Configurations.Add(new TR_Model_Comp_RoleMap());
            modelBuilder.Configurations.Add(new TUserInfoMap());
        }
    }
}
