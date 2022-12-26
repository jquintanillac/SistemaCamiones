using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDTransportistaController : ControllerBase
    {

        IMDTransportistaServices _mDTransportistaServices;
        public SVMDTransportistaController(IMDTransportistaServices mDTransportistaServices)
        {
            _mDTransportistaServices = mDTransportistaServices; 
        }

        // GET: api/<SVMDTransportistaController>
        [HttpGet]
        public IEnumerable<MDTransportista> GetAll()
        {
            return _mDTransportistaServices.GetAll();
        }

        // GET api/<SVMDTransportistaController>/5
        [HttpGet("{id}")]
        public MDTransportista Get(int id)
        {
            return _mDTransportistaServices.GetbyId(id);
        }

        // POST api/<SVMDTransportistaController>
        [HttpPost]
        public void Post([FromForm] MDTransportista mDTransportista)
        {
            if(mDTransportista.id_transp == 0)
            {
                _mDTransportistaServices.Save(mDTransportista);
            }
            else
            {
                _mDTransportistaServices.Update(mDTransportista);
            }
        }


        // DELETE api/<SVMDTransportistaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDTransportistaServices.Delete(id);
        }
    }
}
