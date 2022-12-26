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
    public class SVMDTipo_empleController : ControllerBase
    {
        IMDTipo_empleServices _EmpleServices = null;

        public SVMDTipo_empleController(IMDTipo_empleServices EmpleServices)
        {
            _EmpleServices = EmpleServices;
        }
        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<MDTipo_emple> Get()
        {
            return _EmpleServices.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDTipo_emple Getbyid(int id_tipempl)
        {
            return _EmpleServices.GetbyId(id_tipempl);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDTipo_emple oDTipo)
        {
            if (oDTipo.id_tipempl == 0)
            {
                _EmpleServices.Save(oDTipo);
            }
            else
            {
                _EmpleServices.Update(oDTipo);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _EmpleServices.Delete(id);
        }
    }
}
