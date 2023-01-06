using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class DeveloperDto
    {
        [Required, MaxLength(150)]
        public string Name { get; set; }
        public string? Type { get; set; }
        public int? Followers { get; set; }
    }
}
