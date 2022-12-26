using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Driver.web.IServices;
using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDTipo_servicioController : ControllerBase
    {
        IMDTipo_servicioServices _TipoServices;

        public SVMDTipo_servicioController(IMDTipo_servicioServices TipoServices)
        {
            _TipoServices = TipoServices;
        }

        // GET: api/<SVMDClienteController>
        [HttpGet]
        public IEnumerable<MDTipo_servicio> GetAll()
        {
            return _TipoServices.GetAll();
        }

        // GET api/<SVMDClienteController>/5
        [HttpGet("{id}")]
        public MDTipo_servicio Getbyid(int id_tipserv)
        {
            return _TipoServices.GetbyId(id_tipserv);
        }

        // POST api/<SVMDClienteController>
        [HttpPost]
        public void Post([FromForm] MDTipo_servicio mDTipo_Servicio)
        {
            if (mDTipo_Servicio.id_tipserv == 0)
            {
                _TipoServices.Save(mDTipo_Servicio);
            }
            else
            {
                _TipoServices.Update(mDTipo_Servicio);
            }
        }

        // DELETE api/<SVMDClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _TipoServices.Delete(id);
        }
    }
}
