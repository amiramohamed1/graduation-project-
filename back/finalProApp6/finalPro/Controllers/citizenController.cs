using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalPro.Models;
using finalPro.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class citizenController : ControllerBase
    {
         CitizenRepo cit;
        public citizenController(CitizenRepo _cit)
        {
            cit = _cit;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Citizen> GetCitizen(int id)
        {
            return cit.GetCitizen(id);
        }
    }
}