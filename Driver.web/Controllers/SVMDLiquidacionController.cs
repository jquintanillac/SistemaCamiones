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
    public class SVMDLiquidacionController : ControllerBase
    {
        IMDLiquidacionServices _mDLiquidacionServices;

        public SVMDLiquidacionController(IMDLiquidacionServices mDLiquidacionServices)
        {
            _mDLiquidacionServices = mDLiquidacionServices; 
        }

        // GET: api/<SVMDLiquidacionController>
        [HttpGet]
        public IEnumerable<MDLiquidacion> GetAll()
        {
            return _mDLiquidacionServices.GetAll();
        }

        // GET api/<SVMDLiquidacionController>/5
        [HttpGet("{id}")]
        public MDLiquidacion Getbyid(int id_liqui)
        {
            return _mDLiquidacionServices.GetbyId(id_liqui);
        }

        // POST api/<SVMDLiquidacionController>
        [HttpPost]
        public void Post([FromForm] MDLiquidacion mDLiquidacion)
        {
            if(mDLiquidacion.id_liqui == 0)
            {
                _mDLiquidacionServices.Save(mDLiquidacion); 
            }
            else
            {
                _mDLiquidacionServices.Update(mDLiquidacion);
            }
        }

        // DELETE api/<SVMDLiquidacionController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDLiquidacionServices.Delete(id);
        }
    }
}
