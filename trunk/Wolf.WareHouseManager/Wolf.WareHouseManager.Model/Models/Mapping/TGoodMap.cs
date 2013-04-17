using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wolf.WareHouseManager.Model.Models.Mapping
{
    public class TGoodMap : EntityTypeConfiguration<TGood>
    {
        public TGoodMap()
        {
            // Primary Key
            this.HasKey(t => t.FGoodID);

            // Properties
            this.Property(t => t.FGoodName)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FRemark)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("TGoods");
            this.Property(t => t.FGoodID).HasColumnName("FGoodID");
            this.Property(t => t.FGoodName).HasColumnName("FGoodName");
            this.Property(t => t.FIsFitting).HasColumnName("FIsFitting");
            this.Property(t => t.FRemark).HasColumnName("FRemark");
            this.Property(t => t.FUserID).HasColumnName("FUserID");
            this.Property(t => t.FStatus).HasColumnName("FStatus");
            this.Property(t => t.FCreateTime).HasColumnName("FCreateTime");
        }
    }
}
