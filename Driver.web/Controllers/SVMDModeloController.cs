using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDModeloController : ControllerBase
    {
        IMDModeloServices _modeloServices;

        public SVMDModeloController(IMDModeloServices modeloServices)
        {
            _modeloServices = modeloServices;
        }

        // GET: api/<SVMDClienteController>
        [HttpGet]
        public IEnumerable<MDModelo> GetAll()
        {
            return _modeloServices.GetAll();
        }

        // GET api/<SVMDClienteController>/5
        [HttpGet("{id}")]
        public MDModelo Getbyid(int id_modelo)
        {
            return _modeloServices.GetbyId(id_modelo);
        }

        // POST api/<SVMDClienteController>
        [HttpPost]
        public void Post([FromForm] MDModelo mDModelo)
        {
            if (mDModelo.id_modelo == 0)
            {
                _modeloServices.Save(mDModelo);
            }
            else
            {
                _modeloServices.Update(mDModelo);
            }
        }

        // DELETE api/<SVMDClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _modeloServices.Delete(id);
        }
    }
}
