using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MovieDTO
    {
      
        public string MovieId { get; set; }
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public string MovieDescription { get; set; }
        [Required]
        public string MovieDuration { get; set; }
        [Required]
        public int MoviePicture { get; set; }
    }
}
