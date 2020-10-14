using finalPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalPro.Repositories
{
   public interface IRequest
    {
        List<Requist> getAll();
        Requist getByID(params object[] id);
        List<Requist> getCitizenRequest(int id);
        Requist Add(Requist r);
        bool Update(Requist r);
        bool Delete(Requist r);
        List<Requist> getUserRequset(int id);
        bool Response(int id);
       Requist changeStatus(int id);
        int counter(int id,int uid);
    }
}
