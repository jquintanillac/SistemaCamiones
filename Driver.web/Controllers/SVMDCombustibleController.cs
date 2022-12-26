using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;
using Driver.web.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDCombustibleController : ControllerBase
    {

        IMDCombustibleServices _mDCombustible;
        public SVMDCombustibleController(IMDCombustibleServices mDCombustible)
        {
            _mDCombustible = mDCombustible;
        }

        // GET: api/<SVMDCombustibleController>
        [HttpGet]
        public IEnumerable<VMDCombustible> GetAll()
        {
            return _mDCombustible.GetAll();
        }

        // GET api/<SVMDCombustibleController>/5
        [HttpGet("{id}")]
        public MDCombustible Getbyid(int id)
        {
            return _mDCombustible.GetbyId(id);
        }

        // POST api/<SVMDCombustibleController>
        [HttpPost]
        public void Post([FromForm] MDCombustible mDCombustible)
        {
            if(mDCombustible.id_combu == 0)
            {
                _mDCombustible.Save(mDCombustible);
            }
            else
            {
                _mDCombustible.Update(mDCombustible);
            }
        }

        // DELETE api/<SVMDCombustibleController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDCombustible.Delete(id);
        }
    }
}
