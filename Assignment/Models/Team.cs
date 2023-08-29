using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{

    [Table("Team")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        [StringLength(50)]
        public string TeamName { get; set; }
        [Required]

        public int NOWC { get; set; }
    }
}