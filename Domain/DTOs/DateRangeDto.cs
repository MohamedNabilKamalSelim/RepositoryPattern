using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class DateRangeDto
    {
        [Required]
        public DateTime FromStartDate { get; set; }

        [Required]
        public DateTime ToEndDate { get; set; }
    }
}
