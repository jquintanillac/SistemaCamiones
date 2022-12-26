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
    public class MDCargaController : ControllerBase
    {
        IMDcargaServices _mDcargaServices = null;

        public MDCargaController(IMDcargaServices mDcargaServices)
        {
            _mDcargaServices = mDcargaServices;
        }

        // GET: api/<MDCargaController>
        [HttpGet]
        public IEnumerable<MDCarga> GetAllMDcarga()
        {
            return _mDcargaServices.GetMDCargas();
        }

        // GET api/<MDCargaController>/5
        [HttpGet("{id}")]
        public MDCarga GetbyId(int id_carga)
        {
            return _mDcargaServices.GetbyId(id_carga);
        }

        // POST api/<MDCargaController>
        [HttpPost]
        public void SaveOrUpdate([FromForm] MDCarga mDCarga)
        {
            if (mDCarga.id_carga == 0)
            {
                _mDcargaServices.Save(mDCarga);
            }
            else
            {
                _mDcargaServices.Update(mDCarga);
            }
        }

        // DELETE api/<MDCargaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDcargaServices.Delete(id);
        }
    }
}
