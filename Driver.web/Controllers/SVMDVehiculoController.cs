using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDVehiculoController : ControllerBase
    {
        IMDVehiculoServices _mDVehiculo;

        public SVMDVehiculoController(IMDVehiculoServices mDVehiculo)
        {
            _mDVehiculo = mDVehiculo;
        }

        // GET: api/<SVMDClienteController>
        [HttpGet]
        public IEnumerable<MDVehiculo> GetAll()
        {
            return _mDVehiculo.GetAll();
        }

        // GET api/<SVMDClienteController>/5
        [HttpGet("{id}")]
        public MDVehiculo Getbyid(int id_vehi)
        {
            return _mDVehiculo.GetbyId(id_vehi);
        }

        // POST api/<SVMDClienteController>
        [HttpPost]
        public void Post([FromForm] MDVehiculo mDVehiculo)
        {
            if (mDVehiculo.id_vehi == 0)
            {
                _mDVehiculo.Save(mDVehiculo);
            }
            else
            {
                _mDVehiculo.Update(mDVehiculo);
            }
        }

        // DELETE api/<SVMDClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDVehiculo.Delete(id);
        }
    }
}
