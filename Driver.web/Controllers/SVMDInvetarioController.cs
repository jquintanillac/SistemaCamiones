using Microsoft.AspNetCore.Mvc;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using Driver.web.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDInvetarioController : ControllerBase
    {
        IMDInventarioServices _mDInventario;

        public SVMDInvetarioController(IMDInventarioServices mDInventario)
        {
            _mDInventario = mDInventario;
        }

        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<VMDInventario> Get()
        {
            return _mDInventario.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDInventario Getbyid(int id_invet)
        {
            return _mDInventario.GetbyId(id_invet);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDInventario oDInventario)
        {
            if (oDInventario.id_invet == 0)
            {
                _mDInventario.Save(oDInventario);
            }
            else
            {
                _mDInventario.Update(oDInventario);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDInventario.Delete(id);
        }
    }
}
