using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF
{
    class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }
        public double Bouns { get; set; }
        [Column(TypeName = "money")]
        public int salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int Dept_Id { get; set; }

    }
}
