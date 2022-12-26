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
    public class SVMDProceso_VehiculoDetalleController : ControllerBase
    {
        IMDProceso_VehiculoDetalle _Detallevehiculo = null;

        public SVMDProceso_VehiculoDetalleController(IMDProceso_VehiculoDetalle Detallevehiculo)
        {
            _Detallevehiculo = Detallevehiculo;
        }

        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<VMProceso_VehiculoDetalle> Get()
        {
            return _Detallevehiculo.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public IEnumerable<VMProceso_VehiculoDetalle> Getbyid(int id)
        {
            return _Detallevehiculo.GetbyId(id);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDProceso_VehiculoDetalle mProvehidet)
        {
            if (mProvehidet.id_provehidet == 0)
            {
                _Detallevehiculo.Save(mProvehidet);
            }
            else
            {
                _Detallevehiculo.Update(mProvehidet);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _Detallevehiculo.Delete(id);
        }
    }
}
