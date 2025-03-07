using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF
{
    class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Duration { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100, MinimumLength = 20)]
        public string Description { get; set; }
        public int Top_Id { get; set; }

    }
}
