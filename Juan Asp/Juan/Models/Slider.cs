using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 35)]
        public string Title1 { get; set; }
        [StringLength(maximumLength: 35)]
        public string Title2 { get; set; }
        [StringLength(maximumLength: 200)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }
        [StringLength(maximumLength: 30)]
        public string BtnText { get; set; }
    }
}
