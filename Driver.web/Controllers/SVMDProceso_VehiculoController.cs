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
    public class SVMDProceso_VehiculoController : ControllerBase
    {
        IMDProceso_VehiculoServices _Procvehiculo = null;

        public SVMDProceso_VehiculoController(IMDProceso_VehiculoServices Procvehiculo)
        {
            _Procvehiculo = Procvehiculo;
        }

        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<VMProceso_Vehiculo> Get()
        {
            return _Procvehiculo.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDProceso_Vehiculo Getbyid(int id_provehi)
        {
            return _Procvehiculo.GetbyId(id_provehi);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDProceso_Vehiculo oProcvechi)
        {
            if (oProcvechi.id_provehi == 0)
            {
                _Procvehiculo.Save(oProcvechi);
            }
            else
            {
                _Procvehiculo.Update(oProcvechi);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _Procvehiculo.Delete(id);
        }
    }
}
