using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public string Uname { get; set; }
        [Required]
        [StringLength(30)]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UserAddress { get; set; }
        [Required]
        public int UserPhone { get; set; }
        [Required]
        public string UserGender { get; set; }
        [Required]
        [StringLength(20)]
        public string UserPassword { get; set; }
        [ForeignKey("Movie")]
        public string MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
