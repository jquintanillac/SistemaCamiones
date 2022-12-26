using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;
using Driver.web.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDDocumento_CabeceraController : ControllerBase
    {

        IMDDocumento_CabeceraServices _mDDocumento_CabeceraServices;

        public SVMDDocumento_CabeceraController(IMDDocumento_CabeceraServices mDDocumento_CabeceraServices)
        {
            _mDDocumento_CabeceraServices = mDDocumento_CabeceraServices;
        }

        // GET: api/<SVMDDocumento_CabeceraController>
        [HttpGet]
        public IEnumerable<VMDocumento_Cabecera> GetAll()
        {
            return _mDDocumento_CabeceraServices.GetAll();
        }

        // GET api/<SVMDDocumento_CabeceraController>/5
        [HttpGet("{id}")]
        public IEnumerable<VMDocumento_Cabecera> Getbyid(string id)
        {
            return _mDDocumento_CabeceraServices.GetbyId(id);
        }

        // POST api/<SVMDDocumento_CabeceraController>
        [HttpPost]
        public void Post([FromForm] VMDocumento_Cabecera mDDocumento_Cabecera)
        {
            if (mDDocumento_Cabecera.id_doccab == 0)
            {
                _mDDocumento_CabeceraServices.Save(mDDocumento_Cabecera);
            }
            else
            {
                _mDDocumento_CabeceraServices.Update(mDDocumento_Cabecera);
            }
        }

        // DELETE api/<SVMDDocumento_CabeceraController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDDocumento_CabeceraServices.Delete(id);
        }
    }
}
