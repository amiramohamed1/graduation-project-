using finalPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalPro.Repositories
{
   public interface ICitizen
    {
        List<Citizen> GetCitizens();
        Citizen AddCitizen(Citizen dt);
        Citizen GetCitizen(int id);
    }
}
