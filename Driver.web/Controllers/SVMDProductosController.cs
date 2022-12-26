using Driver.web.Data.Entities;
using Driver.web.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDProductosController : ControllerBase
    {
        IMDProductoServices _mDProducto;

        public SVMDProductosController(IMDProductoServices mDProducto)
        {
            _mDProducto = mDProducto;
        }
        // GET: api/<SVMDChoferController>
        [HttpGet]
        public IEnumerable<MDProducto> Get()
        {
            return _mDProducto.GetAll();
        }

        // GET api/<SVMDChoferController>/5
        [HttpGet("{id}")]
        public MDProducto Getbyid(int id_product)
        {
            return _mDProducto.GetbyId(id_product);
        }

        // POST api/<SVMDChoferController>
        [HttpPost]
        public void Post([FromForm] MDProducto oProducto)
        {
            if (oProducto.id_product == 0)
            {
                _mDProducto.Save(oProducto);
            }
            else
            {
                _mDProducto.Update(oProducto);
            }
        }

        // DELETE api/<SVMDChoferController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDProducto.Delete(id);
        }
    }
}
