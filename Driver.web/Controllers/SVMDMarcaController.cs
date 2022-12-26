using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDMarcaController : ControllerBase
    {
        IMDMarcaServices _DMarcaServices;

        public SVMDMarcaController(IMDMarcaServices DMarcaServices)
        {
            _DMarcaServices = DMarcaServices;
        }

        // GET: api/<SVMDClienteController>
        [HttpGet]
        public IEnumerable<MDMarca> GetAll()
        {
            return _DMarcaServices.GetAll();
        }

        // GET api/<SVMDClienteController>/5
        [HttpGet("{id}")]
        public MDMarca Getbyid(int id_marca)
        {
            return _DMarcaServices.GetbyId(id_marca);
        }

        // POST api/<SVMDClienteController>
        [HttpPost]
        public void Post([FromForm] MDMarca mDMarca)
        {
            if (mDMarca.id_marca == 0)
            {
                _DMarcaServices.Save(mDMarca);
            }
            else
            {
                _DMarcaServices.Update(mDMarca);
            }
        }

        // DELETE api/<SVMDClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _DMarcaServices.Delete(id);
        }
    }
}
