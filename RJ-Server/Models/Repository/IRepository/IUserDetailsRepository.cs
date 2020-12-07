using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Models.Repository.IRepository
{
   public interface IUserDetailsRepository
    {
        ICollection<UserDetails> GetUserDetails();

        UserDetails GetUserDetail(int userName);
        bool UserDetailsNameExist(string name);
        bool UserDetailsIdExist(string id);
        bool CreateUserDetails(UserDetails userDetail);
        bool UpadteUserDetails(UserDetails userDetail);
        bool DeleteUserDetails(UserDetails userDetail);
        bool Save();
    }
}
