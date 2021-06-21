using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static ShortenerLinks.Models.Validation.CustomValidation;

namespace ShortenerLinks.Models.Entities
{
    public class ShortURLRequestModel
    {
        [Required]
        [CheckUrlValid(ErrorMessage = "Please enter a valid Url")]
        public string LongUrl { get; set; }

        public DateTime TimeStamp
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
