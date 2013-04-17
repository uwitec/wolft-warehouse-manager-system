using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wolf.WareHouseManager.Model.Models.Mapping
{
    public class TR_Model_Comp_RoleMap : EntityTypeConfiguration<TR_Model_Comp_Role>
    {
        public TR_Model_Comp_RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.FRelationID);

            // Properties
            this.Property(t => t.FRemark)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("TR_Model_Comp_Role");
            this.Property(t => t.FRelationID).HasColumnName("FRelationID");
            this.Property(t => t.FRoleID).HasColumnName("FRoleID");
            this.Property(t => t.FModelID).HasColumnName("FModelID");
            this.Property(t => t.FCompId).HasColumnName("FCompId");
            this.Property(t => t.FStatus).HasColumnName("FStatus");
            this.Property(t => t.FRemark).HasColumnName("FRemark");
            this.Property(t => t.FCreateTime).HasColumnName("FCreateTime");
        }
    }
}
