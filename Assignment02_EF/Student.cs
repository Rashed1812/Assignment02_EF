using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF
{
    class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        [StringLength(50,MinimumLength =10)]
        public string FName { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(21,60)]
        public int Age { get; set; }
        public int Dept_Id { get; set; }


    }
}
