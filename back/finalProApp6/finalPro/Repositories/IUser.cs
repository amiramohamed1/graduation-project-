using finalPro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalPro.Repositories
{
   public interface IUser<T>
    {
        List<T> getAll();
        List<User> getallUsersFilterd(int id);
        T getByID(params object[] id);
        User Add(User t);
        bool Update(T t);
        bool Delete(int id);
        User Search(string userName, string password);

    }
}
