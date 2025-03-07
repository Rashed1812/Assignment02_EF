using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Configuration
{
    class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        #region Fluent API
        public void Configure(EntityTypeBuilder<Department> d)
        {
            d.ToTable("Department");
            d.HasKey(d => d.Id);
            d.Property(d => d.Id)
                .UseIdentityColumn(1, 1);
            d.Property(d => d.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(true)
                .HasDefaultValue("CS");
            d.Property(d => d.HiringDate)
                .HasAnnotation("DataType", "DateTime")
                .HasDefaultValue(DateTime.Now)
                .HasDefaultValueSql("GetDate()");
            //.HasComputedColumnSql("GetDate()");
            throw new NotImplementedException();
        } 
        #endregion
    }
}
