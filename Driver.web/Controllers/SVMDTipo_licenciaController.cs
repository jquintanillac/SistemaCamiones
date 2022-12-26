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
    public class SVMDTipo_licenciaController : ControllerBase
    {
        IMDTipo_licenciaServices _LicenciaServices = null;

        public SVMDTipo_licenciaController(IMDTipo_licenciaServices LicenciaServices)
        {
            _LicenciaServices = LicenciaServices;
        }

        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<MDTipo_licencia> Get()
        {
            return _LicenciaServices.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDTipo_licencia Getbyid(int id_tiplinc)
        {
            return _LicenciaServices.GetbyId(id_tiplinc);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDTipo_licencia mDTipo)
        {
            if (mDTipo.id_tiplinc == 0)
            {
                _LicenciaServices.Save(mDTipo);
            }
            else
            {
                _LicenciaServices.Update(mDTipo);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _LicenciaServices.Delete(id);
        }
    }
}
