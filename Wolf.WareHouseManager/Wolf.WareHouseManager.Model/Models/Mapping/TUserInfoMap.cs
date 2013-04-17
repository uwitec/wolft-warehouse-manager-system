using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wolf.WareHouseManager.Model.Models.Mapping
{
    public class TUserInfoMap : EntityTypeConfiguration<TUserInfo>
    {
        public TUserInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.FUserID);

            // Properties
            this.Property(t => t.FUserName)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FNickName)
                .HasMaxLength(32);

            this.Property(t => t.FPassword)
                .HasMaxLength(32);

            this.Property(t => t.FTelPhone)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.FAddress)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("TUserInfo");
            this.Property(t => t.FUserID).HasColumnName("FUserID");
            this.Property(t => t.FUserName).HasColumnName("FUserName");
            this.Property(t => t.FNickName).HasColumnName("FNickName");
            this.Property(t => t.FPassword).HasColumnName("FPassword");
            this.Property(t => t.FTelPhone).HasColumnName("FTelPhone");
            this.Property(t => t.FAddress).HasColumnName("FAddress");
            this.Property(t => t.FRoleID).HasColumnName("FRoleID");
            this.Property(t => t.FStatus).HasColumnName("FStatus");
            this.Property(t => t.FCreateTime).HasColumnName("FCreateTime");
        }
    }
}
