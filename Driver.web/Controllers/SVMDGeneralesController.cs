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
    public class SVMDGeneralesController : ControllerBase
    {
        IMDGeneralesServices _mDGenerales = null;

        public SVMDGeneralesController(IMDGeneralesServices mDGenerales)
        {
            _mDGenerales = mDGenerales;
        }
        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<MDGenerales> Get()
        {
            return _mDGenerales.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDGenerales Getbyid(int id_gene)
        {
            return _mDGenerales.GetbyId(id_gene);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDGenerales oDGenerales)
        {
            if (oDGenerales.id_gene == 0)
            {
                _mDGenerales.Save(oDGenerales);
            }
            else
            {
                _mDGenerales.Update(oDGenerales);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDGenerales.Delete(id);
        }
    }
}
