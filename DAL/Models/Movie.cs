using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Movie
    {
        [Key]
        public string MovieId { get; set; }
        [Required]
        [StringLength(30)]
        public string MovieTitle { get; set; }
        [Required]
        public string MovieDescription { get; set; }
        [Required]
        public string MovieDuration { get; set; }
        [Required]
        public int MoviePicture { get; set; }

        public virtual ICollection<User> Movies { get; set; }

        public Movie()
        {
            Movies = new List<User>();

        }
       
        
    }
}
