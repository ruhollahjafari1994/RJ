using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Models.Dtos
{
     
    public class UserDetailsDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserPassword { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Family { get; set; }

        public string UserMobile { get; set; }


        DateTime UserBirthDay { get; set; }

        [Required]
        public string UserEmail { get; set; }
        [Required]
        public bool UserSex { get; set; }

        [Required]
        public bool UserActive { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        DateTime UserCreated { get; set; }

        [Required]
        string UserIp { get; set; }


        DateTime UserLogin { get; set; }
        public string UserCity { get; set; }

        public string UserCounty { get; set; }

        public string UserAddress { get; set; }
    }
}
