using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Models.Dtos
{
     
    public class UserDetailsDto
    {
        public Guid UserId { get; set; } = new Guid();

         public string UserName { get; set; }

         public string UserPassword { get; set; }

         public string Name { get; set; }

         public string Family { get; set; }

        public string UserMobile { get; set; }


        DateTime UserBirthDay { get; set; }

         public string UserEmail { get; set; }
         public bool UserSex { get; set; }

         public bool UserActive { get; set; }

         public bool IsAdmin { get; set; }

         DateTime UserCreated { get; set; } 


        DateTime UserLogin { get; set; } 
        public string UserCity { get; set; }

        public string UserCounty { get; set; }

        public string UserAddress { get; set; }
    }
}
