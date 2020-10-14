using finalPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalPro.Repositories
{
    public class OrganisationRepo:IOrganization
    {
        private finalProDBContext fp;
        public OrganisationRepo(finalProDBContext _fb)
        {
            this.fp = _fb;
        }



        public List<string> orgNames()
        {
            return fp.Organization.Select(a => a.Name).ToList();
        }

    }
}
