using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wolf.WareHouseManager.Model.Models.Mapping
{
    public class TPriceMap : EntityTypeConfiguration<TPrice>
    {
        public TPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.FPriceID);

            // Properties
            this.Property(t => t.FRemark)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("TPrice");
            this.Property(t => t.FPriceID).HasColumnName("FPriceID");
            this.Property(t => t.FGoodID).HasColumnName("FGoodID");
            this.Property(t => t.FPrice).HasColumnName("FPrice");
            this.Property(t => t.FUserID).HasColumnName("FUserID");
            this.Property(t => t.FStatus).HasColumnName("FStatus");
            this.Property(t => t.FPriceTime).HasColumnName("FPriceTime");
            this.Property(t => t.FRemark).HasColumnName("FRemark");
            this.Property(t => t.FCreateTime).HasColumnName("FCreateTime");
        }
    }
}
