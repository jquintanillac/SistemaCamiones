using Driver.web.Data.Entities;
using Driver.web.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDEspecialidadController : ControllerBase
    {
        IMDEspecialidadServices _DEspecialidad = null;

        public SVMDEspecialidadController(IMDEspecialidadServices DEspecialidad)
        {
            _DEspecialidad = DEspecialidad;
        }


        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<MDEspecialidad> Get()
        {
            return _DEspecialidad.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDEspecialidad Getbyid(int id_espec)
        {
            return _DEspecialidad.GetbyId(id_espec);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDEspecialidad mDEspec)
        {
            if (mDEspec.id_espec == 0)
            {
                _DEspecialidad.Save(mDEspec);
            }
            else
            {
                _DEspecialidad.Update(mDEspec);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _DEspecialidad.Delete(id);
        }
    }
}
