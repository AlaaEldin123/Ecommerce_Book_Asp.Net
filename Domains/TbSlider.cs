using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domains
{ 
    public partial class TbSlider
    {
        [Key]
        public int SliderId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Descraption { get; set; }
        [Required]
        [MaxLength(200)]
        public string ImageName { get; set; }
    }
}
