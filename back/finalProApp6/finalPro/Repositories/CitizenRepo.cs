using finalPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalPro.Repositories
{
    public class CitizenRepo:ICitizen
    {
        finalProDBContext db;
        public CitizenRepo(finalProDBContext _db)
        {
            db = _db;
        }
        public List<Citizen> GetCitizens()
        {
            return db.Citizen.ToList();
        }
        public Citizen AddCitizen(Citizen ct)
        {
            db.Citizen.Add(ct);
            return db.SaveChanges() > 0 ? ct : null;
        }

        public Citizen GetCitizen(int id)
        {
            var x= db.Citizen.Where(e => e.Id == id).SingleOrDefault();
            return x;
        }
    }
}
