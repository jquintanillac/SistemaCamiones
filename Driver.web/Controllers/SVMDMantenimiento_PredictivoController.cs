using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDMantenimiento_PredictivoController : ControllerBase
    {

        IMDMantenimiento_PredictivoServices _mDMantenimiento_PredictivoServices;

        public SVMDMantenimiento_PredictivoController(IMDMantenimiento_PredictivoServices mDMantenimiento_PredictivoServices)
        {
            _mDMantenimiento_PredictivoServices = mDMantenimiento_PredictivoServices;
        }

        // GET: api/<SVMDMantenimiento_PredictivoController>
        [HttpGet]
        public IEnumerable<MDMantenimiento_Predictivo> GetAll()
        {
            return _mDMantenimiento_PredictivoServices.GetAll();
        }

        // GET api/<SVMDMantenimiento_PredictivoController>/5
        [HttpGet("{id}")]
        public MDMantenimiento_Predictivo Getbyid(int id)
        {
            return _mDMantenimiento_PredictivoServices.GetbyId(id);
        }

        // POST api/<SVMDMantenimiento_PredictivoController>
        [HttpPost]
        public void Post([FromForm] MDMantenimiento_Predictivo mDMantenimiento_Predictivo)
        {
            if(mDMantenimiento_Predictivo.id_mantpred == 0)
            {
                _mDMantenimiento_PredictivoServices.Save(mDMantenimiento_Predictivo);
            }
            else
            {
                _mDMantenimiento_PredictivoServices.Update(mDMantenimiento_Predictivo);
            }
        }


        // DELETE api/<SVMDMantenimiento_PredictivoController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDMantenimiento_PredictivoServices.Delete(id);
        }
    }
}
