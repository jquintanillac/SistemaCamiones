using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDRolController : ControllerBase
    {
        IMDRolServices _mDRolServices;

        public SVMDRolController(IMDRolServices mDRolServices)
        {
            _mDRolServices = mDRolServices;
        }

        // GET: api/<SVMDRolController>
        [HttpGet]
        public IEnumerable<MDRol> GetAll()
        {
            return _mDRolServices.GetAll();
        }

        // GET api/<SVMDRolController>/5
        [HttpGet("{id}")]
        public MDRol Getbyid(int id)
        {
            return _mDRolServices.GetbyId(id);
        }

        // POST api/<SVMDRolController>
        [HttpPost]
        public void Post([FromForm] MDRol mDRol)
        {
            if(mDRol.Idrol == 0)
            {
                _mDRolServices.Save(mDRol);
            }
            else
            {
                _mDRolServices.Update(mDRol);
            }
        }


        // DELETE api/<SVMDRolController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDRolServices.Delete(id);   
        }
    }
}
