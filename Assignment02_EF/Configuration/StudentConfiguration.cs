using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Configuration
{
    class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> s)
        {
            s.ToTable("Student");
            s.HasKey(s => s.Id);
            s.Property(s => s.Id)
                .UseIdentityColumn(100, 1);

            throw new NotImplementedException();
        }
    }
}
