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
    public class SVMDRepuestosController : ControllerBase
    {
        IMDRepuestosServices _mDRepuestosServices;

        public SVMDRepuestosController(IMDRepuestosServices mDRepuestosServices)
        {
            _mDRepuestosServices = mDRepuestosServices;
        }


        // GET: api/<SVMDRepuestosController>
        [HttpGet]
        public IEnumerable<VMDRepuestos> GetAll()
        {
            return _mDRepuestosServices.GetAll();
        }

        // GET api/<SVMDRepuestosController>/5
        [HttpGet("{id}")]
        public MDRepuestos Getbyid(int id)
        {
            return _mDRepuestosServices.GetbyId(id);
        }

        // POST api/<SVMDRepuestosController>
        [HttpPost]
        public void Post([FromForm] MDRepuestos mDRepuestos)
        {
            if(mDRepuestos.id_repuesto == 0)
            {
                _mDRepuestosServices.Save(mDRepuestos);
            }
            else
            {
                _mDRepuestosServices.Update(mDRepuestos);
            }
        }


        // DELETE api/<SVMDRepuestosController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDRepuestosServices.Delete(id);
        }
    }
}
