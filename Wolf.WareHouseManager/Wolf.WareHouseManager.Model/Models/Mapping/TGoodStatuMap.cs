using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wolf.WareHouseManager.Model.Models.Mapping
{
    public class TGoodStatuMap : EntityTypeConfiguration<TGoodStatu>
    {
        public TGoodStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.FStatusID);

            // Properties
            this.Property(t => t.FStatusName)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FRemark)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("TGoodStatus");
            this.Property(t => t.FStatusID).HasColumnName("FStatusID");
            this.Property(t => t.FStatusName).HasColumnName("FStatusName");
            this.Property(t => t.FRemark).HasColumnName("FRemark");
            this.Property(t => t.FUserID).HasColumnName("FUserID");
            this.Property(t => t.FStatus).HasColumnName("FStatus");
            this.Property(t => t.FCreateTime).HasColumnName("FCreateTime");
        }
    }
}
