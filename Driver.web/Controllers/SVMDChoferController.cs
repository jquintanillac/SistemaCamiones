using Driver.web.Data.Entities;
using Driver.web.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDChoferController : ControllerBase
    {
        IMDChoferServices _mDChoferServices = null;

        public SVMDChoferController(IMDChoferServices mDChoferServices)
        {
            _mDChoferServices = mDChoferServices;
        }

        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<MDChofer> Get()
        {
            return _mDChoferServices.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDChofer Getbyid(int id_chofer)
        {
            return _mDChoferServices.GetbyId(id_chofer);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDChofer mDChofer)
        {
            if (mDChofer.id_chofer == 0)
            {
                _mDChoferServices.Save(mDChofer);
            }
            else
            {
                _mDChoferServices.Update(mDChofer);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDChoferServices.Delete(id);
        }
    }
}
