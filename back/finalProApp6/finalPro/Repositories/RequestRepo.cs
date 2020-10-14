using finalPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalPro.Repositories
{
    public class RequestRepo : IRequest
    {
        private finalProDBContext ctx;

        public RequestRepo()
        {
            ctx = new finalProDBContext();
        }

        public List<Requist> getAll()
        {
            return ctx.Requist.ToList();
        }

        public Requist getByID(params object[] id)
        {
            return ctx.Requist.Find(id);
        }


        public List<Requist> getCitizenRequest(int id)
        {
            return ctx.Requist.Where(e => e.CitId == id).ToList();
        }
        public Requist Add(Requist r)
        {
            ctx.Requist.Add(r);
            return ctx.SaveChanges() > 0 ? r : null;
        }

        public bool Update(Requist r)
        {
            ctx.Requist.Attach(r);
            ctx.Entry(r).State = EntityState.Modified;
            return ctx.SaveChanges() > 0;
        }

        public bool Delete(Requist r)
        {
            ctx.Requist.Remove(r);
            return ctx.SaveChanges() > 0;
        }

        public List<Requist> getUserRequset(int id)
        {
            var req = ctx.Requist.Where(e => e.UserId == id)
                          .Include(e => e.Cit);
            return req.ToList();
        }

        public bool Response(int id)
        {
            var x = ctx.Requist.Where(e => e.Id == id).SingleOrDefault();
            if (x.Response == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Requist changeStatus(int id)
        {

            var x = ctx.Requist.Find(id);
            x.Response = true;
            ctx.SaveChanges();
            return x;
        }

        public int counter(int id,int uid)
        {
            var x = ctx.Requist.Where(e => e.OrgId == id).Where(e=>e.UserId==uid).Count();
            return x;
        }
    }
}
