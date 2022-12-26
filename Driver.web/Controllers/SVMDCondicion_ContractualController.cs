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
    public class SVMDCondicion_ContractualController : ControllerBase
    {
        IMDCondicion_ContractualServices _ContractualServices = null;

        public SVMDCondicion_ContractualController(IMDCondicion_ContractualServices ContractualServices)
        {
            _ContractualServices = ContractualServices;
        }

        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<MDCondicion_Contractual> Get()
        {
            return _ContractualServices.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDCondicion_Contractual Getbyid(int id_concontrac)
        {
            return _ContractualServices.GetbyId(id_concontrac);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDCondicion_Contractual oDCondicion)
        {
            if (oDCondicion.id_concontrac == 0)
            {
                _ContractualServices.Save(oDCondicion);
            }
            else
            {
                _ContractualServices.Update(oDCondicion);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _ContractualServices.Delete(id);
        }
    }
}
