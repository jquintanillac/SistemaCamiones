using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDUsuarioController : ControllerBase
    {
        IMDUsuarioServices _mDUsuarioServices;
        public SVMDUsuarioController(IMDUsuarioServices mDUsuarioServices)
        {
            _mDUsuarioServices = mDUsuarioServices;
        }

        // GET: api/<SVMDUsuarioController>
        [HttpGet]
        public IEnumerable<MDUsuario> GetAll()
        {
            return _mDUsuarioServices.GetAll();
        }

        // GET api/<SVMDUsuarioController>/5
        [HttpGet("{id}")]
        public MDUsuario Getbyid(int id)
        {
            return _mDUsuarioServices.GetbyId(id);
        }

        // POST api/<SVMDUsuarioController>
        [HttpPost]
        public void Post([FromForm] MDUsuario mDUsuario)
        {
            if(mDUsuario.IdUsuario == 0)
            {
                _mDUsuarioServices.Save(mDUsuario);
            }
            else
            {
                _mDUsuarioServices.Update(mDUsuario);
            }
        }

        // DELETE api/<SVMDUsuarioController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDUsuarioServices.Delete(id);
        }
    }
}
