using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDProveedorController : ControllerBase
    {
        IMDProveedorServices _mDProveedorServices;

        public SVMDProveedorController(IMDProveedorServices mDProveedorServices)
        {
            _mDProveedorServices = mDProveedorServices;
        }

        // GET: api/<SVMDProveedorController>
        [HttpGet]
        public IEnumerable<MDProveedor> GetAll()
        {
            return _mDProveedorServices.GetAll();
        }

        // GET api/<SVMDProveedorController>/5
        [HttpGet("{id}")]
        public MDProveedor Getbyid(int id)
        {
            return _mDProveedorServices.GetbyId(id);
        }

        // POST api/<SVMDProveedorController>
        [HttpPost]
        public void Post([FromForm] MDProveedor mDProveedor)
        {
            if(mDProveedor.id_proveedor == 0)
            {
                _mDProveedorServices.Save(mDProveedor);
            }
            else
            {
                _mDProveedorServices.Update(mDProveedor);
            }
        }


        // DELETE api/<SVMDProveedorController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDProveedorServices.Delete(id);
        }
    }
}
