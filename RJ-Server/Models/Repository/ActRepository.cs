using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Models.Repository
{
    public class ActRepository : RJ_Server.Models.Repository.IRepository.IActRepository
    {
        private readonly RJ_Server.Data.ApplicationDbContext _db;
        public ActRepository(RJ_Server.Data.ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CreateUserDetails(Act act)
        {
            _db.Acts.Add(act);
            return Save();
        }

        public bool DeleteAct(Act act)
        {
            _db.Acts.Remove(act);
            return Save();
        }

        public Act GetAct(string act)
        {
            return _db.Acts.FirstOrDefault(a => a.ActName.ToLower().Trim() == act.ToLower().Trim()); ;
        }

        public Act GetAct(int act)
        {
            throw new NotImplementedException();
        }

        public ICollection<Act> GetAct()
        {
            return _db.Acts.OrderBy(a => a.ActName).ToList();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpadteAct(Act act)
        {
            _db.Acts.Update(act);
            return Save();
        }

        public bool ActExist(string name)
        {
            bool value = _db.Acts.Any(a => a.ActName.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool ActIdExist(string id)
        {
            return _db.Acts.Any(a => a.ActName==id);
        }
 

        public bool ActCreated(Act act)
        {
            return _db.Acts.Any(a => a.ActDateCreated == DateTime.Now);
        }
 
    }
}
