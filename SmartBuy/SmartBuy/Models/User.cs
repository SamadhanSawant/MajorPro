using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartBuy.Model
{
    [Table(name:"UsersTable")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "FirstName is required.")]
        [MaxLength(25, ErrorMessage = "FirstName cannot be longer than 25 characters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        [MaxLength(25, ErrorMessage = "LastName cannot be longer than 25 characters.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "EmailId is required.")]
        [MaxLength(40, ErrorMessage = "EmailId cannot be longer than 40 characters.")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "UserName is required.")]
        [MaxLength(40, ErrorMessage = "UserName cannot be longer than 40 characters.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [MaxLength(40, ErrorMessage = "Password cannot be longer than 40 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        [MaxLength(10, ErrorMessage = "Gender cannot be longer than 10 characters.")]
        public string Gender { get; set; }

        public virtual Address Address { get; set; } //One to One relationship
        
    }
}
