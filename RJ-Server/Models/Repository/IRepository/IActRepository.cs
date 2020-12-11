using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Models.Repository.IRepository
{
   public interface IActRepository
    {
        ICollection<Act> GetAct();

        Act GetAct(string userName);
        bool ActExist(string name);
        bool ActIdExist(string id);
        bool ActCreated(Act act);
        bool UpadteAct(Act act);
        bool DeleteAct(Act act);
        bool Save();
    }
}
