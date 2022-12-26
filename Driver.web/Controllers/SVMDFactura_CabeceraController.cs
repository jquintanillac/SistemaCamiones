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
    public class SVMDFactura_CabeceraController : ControllerBase
    {
        IMDFactura_cabeceraServices _mDFactura_Cabecera;
        public SVMDFactura_CabeceraController(IMDFactura_cabeceraServices mDFactura_Cabecera)
        {
            _mDFactura_Cabecera = mDFactura_Cabecera;
        }

        // GET: api/<SVMDFactura_CabeceraController>
        [HttpGet]
        public IEnumerable<MDFactura_Cabecera> GetAll()
        {
            return _mDFactura_Cabecera.GetAll();
        }

        // GET api/<SVMDFactura_CabeceraController>/5
        [HttpGet("{id}")]
        public MDFactura_Cabecera Get(int id)
        {
            return _mDFactura_Cabecera.GetbyId(id);
        }

        // POST api/<SVMDFactura_CabeceraController>
        [HttpPost]
        public void Post([FromForm] MDFactura_Cabecera oMDFactura_Cabecera)
        {
            if(oMDFactura_Cabecera.id_faccab == 0)
            {
                _mDFactura_Cabecera.Save(oMDFactura_Cabecera);
            }
            else
            {
                _mDFactura_Cabecera.Update(oMDFactura_Cabecera);
            }
        }

        // DELETE api/<SVMDFactura_CabeceraController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDFactura_Cabecera.Delete(id);
        }
    }
}
