using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDViaticos_CabeceraController : ControllerBase
    {

        IMDViaticos_CabeceraServices _mDViaticos_CabeceraServices;
        public SVMDViaticos_CabeceraController(IMDViaticos_CabeceraServices mDViaticos_CabeceraServices)
        {
            _mDViaticos_CabeceraServices = mDViaticos_CabeceraServices;
        }

        // GET: api/<SVMDViaticos_CabeceraController>
        [HttpGet]
        public IEnumerable<MDViaticos_Cabecera> GetAll()
        {
            return _mDViaticos_CabeceraServices.GetAll();
        }

        // GET api/<SVMDViaticos_CabeceraController>/5
        [HttpGet("{id}")]
        public MDViaticos_Cabecera Getbyid(int id)
        {
            return _mDViaticos_CabeceraServices.GetbyId(id);
        }

        // POST api/<SVMDViaticos_CabeceraController>
        [HttpPost]
        public void Post([FromForm] MDViaticos_Cabecera mDViaticos_Cabecera)
        {
            if(mDViaticos_Cabecera.id_viatcab == 0)
            {
                _mDViaticos_CabeceraServices.Save(mDViaticos_Cabecera);
            }
            else
            {
                _mDViaticos_CabeceraServices.Update(mDViaticos_Cabecera);
            }
        }

        // DELETE api/<SVMDViaticos_CabeceraController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDViaticos_CabeceraServices.Delete(id); 
        }
    }
}
