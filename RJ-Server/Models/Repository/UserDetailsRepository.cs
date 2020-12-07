using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Models.Repository
{
    public class UserDetailsRepository : RJ_Server.Models.Repository.IRepository.IUserDetailsRepository
    {
        private readonly RJ_Server.Data.ApplicationDbContext _db;
        public UserDetailsRepository(RJ_Server.Data.ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CreateUserDetails(UserDetails userDetail)
        {
            _db.UserDetails.Add(userDetail);
            return Save();
        }

        public bool DeleteUserDetails(UserDetails userDetail)
        {
            _db.UserDetails.Remove(userDetail);
            return Save();
        }

        public UserDetails GetUserDetail(string userName)
        {
            return _db.UserDetails.FirstOrDefault(a => a.UserName.ToLower().Trim() == userName.ToLower().Trim()); ;
        }

        public UserDetails GetUserDetail(int userName)
        {
            throw new NotImplementedException();
        }

        public ICollection<UserDetails> GetUserDetails()
        {
            return _db.UserDetails.OrderBy(a => a.Family).ToList();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpadteUserDetails(UserDetails userDetail)
        {
            _db.UserDetails.Update(userDetail);
            return Save();
        }

        public bool UserDetailsNameExist(string name)
        {
            bool value = _db.UserDetails.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool UserDetailsIdExist(string id)
        {
            return _db.UserDetails.Any(a => a.UserName==id);
        }
    }
}
