using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDProceso_EstadosController : ControllerBase
    {
        IMDProceso_EstadoServices _Procestado = null;

        public SVMDProceso_EstadosController(IMDProceso_EstadoServices Procestado)
        {
            _Procestado = Procestado;
        }

        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<VMProcesoEstado> Get()
        {
            return _Procestado.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDProceso_Estado Getbyid(int id_proest)
        {
            return _Procestado.GetbyId(id_proest);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDProceso_Estado oProcesoest)
        {
            if (oProcesoest.id_proest == 0)
            {
                _Procestado.Save(oProcesoest);
            }
            else
            {
                _Procestado.Update(oProcesoest);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _Procestado.Delete(id);
        }
    }
}
