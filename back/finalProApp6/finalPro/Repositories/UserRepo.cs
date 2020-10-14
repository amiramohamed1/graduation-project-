using finalPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalPro.Repositories
{
    public class UserRepo<T> : IUser<T> where T : class
    {
        private finalProDBContext ctx;
        private DbSet<T> _set;
        public UserRepo(finalProDBContext _ctx)
        {
            this.ctx = _ctx;
            _set = ctx.Set<T>();
        }
        public User Add(User t)
        {
          var a=  ctx.User.Any(x => x.Name == t.Name);
            if(a==false)
            {
                ctx.User.Add(t);
                return ctx.SaveChanges() > 0 ? t : null;
            }
            else
            {
                return null;
            }

        }

        public bool Delete(int id)
        {

            T t = getByID(id);
            _set.Remove(t);
            return ctx.SaveChanges() > 0;
        }

        public List<T> getAll()
        {
            return _set.ToList();
        }
        public List<User> getAllFilter(int id)
        {
            var users = ctx.User.Where(u => u.BranchId == id).ToList();
            return users;
        }

        public List<User> getallUsersFilterd(int id)
        {

            var a = from c in ctx.User
                    join b in ctx.OrgBranches on c.BranchId equals b.Id
                    join m in ctx.Organization on b.OrgId equals m.Id
                    where m.Id == id
                    select c;
            return a.ToList();


        }

        public T getByID(params object[] id)
        {
            return _set.Find(id);
        }

        public User Search(string userName, string password)
        {
            var use = from c in ctx.User
                      where c.Name == userName && c.Password== password
                      select c;
            var a  = use.SingleOrDefault();
            if (a==null)
            {
                return null;
            }
            else
            {
                return a;
            }
            
        }

        public bool Update(T t)
        {
            _set.Attach(t);
            ctx.Entry(t).State = EntityState.Modified;
            return ctx.SaveChanges() > 0;
        }

    }
}
