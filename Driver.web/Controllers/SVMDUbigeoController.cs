using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDUbigeoController : ControllerBase
    {
        IMDUbigeoServices _mDUbigeoServices;

        public SVMDUbigeoController(IMDUbigeoServices mDUbigeoServices)
        {
            _mDUbigeoServices = mDUbigeoServices;   
        }

        // GET: api/<SVMDUbigeoController>
        [HttpGet]
        public IEnumerable<MDUbigeo> GetAll()
        {
            return _mDUbigeoServices.GetAll();
        }

        // GET api/<SVMDUbigeoController>/5
        [HttpGet("{id}")]
        public MDUbigeo Getbyid(int id)
        {
            return _mDUbigeoServices.GetbyId(id);
        }

        // POST api/<SVMDUbigeoController>
        [HttpPost]
        public void Post([FromForm] MDUbigeo mDUbigeo)
        {
            if(mDUbigeo.id_ubigeo == 0)
            {
                _mDUbigeoServices.Save(mDUbigeo);
            }
            else
            {
                _mDUbigeoServices.Update(mDUbigeo);
            }
        }


        // DELETE api/<SVMDUbigeoController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDUbigeoServices.Delete(id);
        }
    }
}
