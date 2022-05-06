using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartBuy.Model
{
    public class Address
    {    
        [Required]
        [Key,ForeignKey("User")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Locality is required.")]
        [MaxLength(25, ErrorMessage = "Locality cannot be longer than 25 characters.")]
        public string Locality { get; set; }
        [Required(ErrorMessage = "City is required.")]
        [MaxLength(25, ErrorMessage = "City cannot be longer than 25 characters.")]
        public string City { get; set; }
        [Required(ErrorMessage = "PinCode is required.")]
        [MaxLength(25, ErrorMessage = "PinCode cannot be longer than 25 characters.")]
        public string PinCode { get; set; }
        [Required(ErrorMessage = "State is required.")]
        [MaxLength(20, ErrorMessage = "State cannot be longer than 20 characters.")]
        public string State { get; set; }
        [Required(ErrorMessage = "Country is required.")]
        [MaxLength(20, ErrorMessage = "Country cannot be longer than 20 characters.")]
        public string Country { get; set; }

        public virtual User User { get; set; } //One to One Relationship
    }
}
