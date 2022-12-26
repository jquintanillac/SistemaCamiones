using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDTipo_semiremolqueController : ControllerBase
    {
        IMDTipo_semiremolqueServices _SemiremolqueServices;

        public SVMDTipo_semiremolqueController(IMDTipo_semiremolqueServices SemiremolqueServices)
        {
            _SemiremolqueServices = SemiremolqueServices;
        }

        // GET: api/<SVMDClienteController>
        [HttpGet]
        public IEnumerable<MDTipo_Semiremolque> GetAll()
        {
            return _SemiremolqueServices.GetAll();
        }

        // GET api/<SVMDClienteController>/5
        [HttpGet("{id}")]
        public MDTipo_Semiremolque Getbyid(int id_Tipsemi)
        {
            return _SemiremolqueServices.GetbyId(id_Tipsemi);
        }

        // POST api/<SVMDClienteController>
        [HttpPost]
        public void Post([FromForm] MDTipo_Semiremolque mDTipo)
        {
            if (mDTipo.id_Tipsemi == 0)
            {
                _SemiremolqueServices.Save(mDTipo);
            }
            else
            {
                _SemiremolqueServices.Update(mDTipo);
            }
        }

        // DELETE api/<SVMDClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _SemiremolqueServices.Delete(id);
        }
    }
}
