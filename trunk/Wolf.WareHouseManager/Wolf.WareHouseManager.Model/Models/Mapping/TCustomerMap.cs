using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wolf.WareHouseManager.Model.Models.Mapping
{
    public class TCustomerMap : EntityTypeConfiguration<TCustomer>
    {
        public TCustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.FCustomerID);

            // Properties
            this.Property(t => t.FCustomerName)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FArtificialPerson)
                .HasMaxLength(32);

            this.Property(t => t.FLicenceNo)
                .HasMaxLength(32);

            this.Property(t => t.FTelPerson)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.FAddress)
                .HasMaxLength(128);

            this.Property(t => t.FRemark)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("TCustomer");
            this.Property(t => t.FCustomerID).HasColumnName("FCustomerID");
            this.Property(t => t.FCustomerName).HasColumnName("FCustomerName");
            this.Property(t => t.FArtificialPerson).HasColumnName("FArtificialPerson");
            this.Property(t => t.FLicenceNo).HasColumnName("FLicenceNo");
            this.Property(t => t.FTelPerson).HasColumnName("FTelPerson");
            this.Property(t => t.FAddress).HasColumnName("FAddress");
            this.Property(t => t.FIsSupplier).HasColumnName("FIsSupplier");
            this.Property(t => t.FRemark).HasColumnName("FRemark");
            this.Property(t => t.FUserID).HasColumnName("FUserID");
            this.Property(t => t.FStatus).HasColumnName("FStatus");
            this.Property(t => t.FCreateTime).HasColumnName("FCreateTime");
        }
    }
}
