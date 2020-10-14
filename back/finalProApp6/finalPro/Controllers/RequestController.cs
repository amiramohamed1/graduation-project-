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
    public class RequestController : ControllerBase
    {
        RequestRepo Req;

        public RequestController(RequestRepo Req)
        {
            this.Req = Req;
        }

        public ActionResult getAll()
        {
            return Ok(Req.getAll());
        }

        [HttpGet]
        [Route("{id}")]
        public Requist getByID(int id)
        {
            return Req.getByID(id);
        }

        [HttpGet]
        [Route("citizen/{id}")]
        public ActionResult getCitizenRequest(int id)
        {
            return Ok(Req.getCitizenRequest(id));
        }

        [HttpGet]
        [Route("user/{id}")]
        public ActionResult getUserRequest(int id)
        {
            return Ok(Req.getUserRequset(id));
        }
        [HttpPost]
        public ActionResult<Requist> Add(Requist r)
        {
            Req.Add(r);
            return Created("Created successfully", r);
        }

        [HttpPut]
        public ActionResult Update(Requist r)
        {
            Req.Update(r);
            return Ok();
        }


        [HttpDelete]
        public ActionResult Delete(Requist r)
        {
            Req.Delete(r);
            return Ok();
        }
        
        [HttpGet]
        [Route("type/{id}")]
        public bool response(int id)
        {
            return Req.Response(id);
        }

        [HttpGet]
        [Route("status/{id}")]
        public Requist changestatu(int id)
        {
           return Req.changeStatus(id);
        }
        [HttpGet]
        [Route("notification/{id}/{uid}")]
        public int count(int id,int uid)
        {
            return Req.counter(id,uid);
        }
    }
}




