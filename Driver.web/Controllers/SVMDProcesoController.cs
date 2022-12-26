using Driver.web.Data.Entities;
using Driver.web.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDProcesoController : ControllerBase
    {
        IMDProcesoServices _Procesos = null;

        public SVMDProcesoController(IMDProcesoServices Procesos)
        {
            _Procesos = Procesos;
        }

        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<MDProceso> Get()
        {
            return _Procesos.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDProceso Getbyid(int id_proces)
        {
            return _Procesos.GetbyId(id_proces);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDProceso oProceso)
        {
            if (oProceso.id_proces == 0)
            {
                _Procesos.Save(oProceso);
            }
            else
            {
                _Procesos.Update(oProceso);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _Procesos.Delete(id);
        }
    }
}
