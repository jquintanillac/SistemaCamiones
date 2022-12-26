using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDEstadosController : ControllerBase
    {
        IMDEstadosServices _mDEstadosServices;

        public SVMDEstadosController(IMDEstadosServices mDEstadosServices)
        {
            _mDEstadosServices = mDEstadosServices;
        }

        // GET: api/<SVMDEstadosController>
        [HttpGet]
        public IEnumerable<MDEstados> GetAll()
        {
            return _mDEstadosServices.GetAll(); 
        }

        // GET api/<SVMDEstadosController>/5
        [HttpGet("{id}")]
        public MDEstados Getbyid(int id)
        {
            return _mDEstadosServices.GetbyId(id);  
        }

        // POST api/<SVMDEstadosController>
        [HttpPost]
        public void Post([FromForm] MDEstados mDEstados)
        {
            if(mDEstados.id_estad == 0)
            {
                _mDEstadosServices.Save(mDEstados); 
            }
            else
            {
                _mDEstadosServices.Update(mDEstados);
            }

        }


        // DELETE api/<SVMDEstadosController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return  _mDEstadosServices.Delete(id);  
        }
    }
}
