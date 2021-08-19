using ContactListMvc.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListMvc.Models
{
    public class ContactListEntry
    {
        [Key]
        public int Id { get; set; }

        public ContactType ContactType { get; set; }

        [MaxLength(200, ErrorMessage = "Name must be less than 200 characters")]
        public string Name { get; set; } = string.Empty;

        [Display(Name="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; } = null;

        [MaxLength(1000, ErrorMessage = "Address must be less than 1000 characters")]
        public string Address { get; set; } = string.Empty;

        [RegularExpression("^[0-9]*$")]
        [MaxLength(50, ErrorMessage = "PhoneNumber must be less than 50 characters")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(200, ErrorMessage = "Email must be less than 200 characters")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
    }
}
