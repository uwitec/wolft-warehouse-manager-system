using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wolf.WareHouseManager.Model.Models.Mapping
{
    public class TCodeTableMap : EntityTypeConfiguration<TCodeTable>
    {
        public TCodeTableMap()
        {
            // Primary Key
            this.HasKey(t => t.FID);

            // Properties
            this.Property(t => t.FName)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FRemark)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("TCodeTable");
            this.Property(t => t.FID).HasColumnName("FID");
            this.Property(t => t.FName).HasColumnName("FName");
            this.Property(t => t.FStatus).HasColumnName("FStatus");
            this.Property(t => t.FRemark).HasColumnName("FRemark");
            this.Property(t => t.FIsTable).HasColumnName("FIsTable");
            this.Property(t => t.FCreateTime).HasColumnName("FCreateTime");
        }
    }
}
