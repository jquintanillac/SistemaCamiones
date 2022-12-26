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
    public class SVMDDocumento_DetalleController : ControllerBase
    {

        IMDDocumento_DetalleServices _DetalleServices;

        public SVMDDocumento_DetalleController(IMDDocumento_DetalleServices DetalleServices)
        {
            _DetalleServices = DetalleServices;
        }

        // GET: api/<SVMDDocumento_DetalleController>
        [HttpGet]
        public IEnumerable<MDDocumento_Detalle> GetAll()
        {
            return _DetalleServices.GetAll();
        }

        // GET api/<SVMDDocumento_DetalleController>/5
        [HttpGet("{id}")]
        public IEnumerable<VMDocumento_Detalle> Getbyid(int id)
        {
            return _DetalleServices.GetbyId(id);
        }

        // POST api/<SVMDDocumento_DetalleController>
        [HttpPost]
        public void Post([FromForm] VMDocumento_Detalle mDDocumento_Detalle)
        {
            if(mDDocumento_Detalle.id_docdet == 0)
            {
                _DetalleServices.Save(mDDocumento_Detalle);
            }
            else
            {
                _DetalleServices.Update(mDDocumento_Detalle);
            }
        }

        // DELETE api/<SVMDDocumento_DetalleController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _DetalleServices.Delete(id);
        }
    }
}
