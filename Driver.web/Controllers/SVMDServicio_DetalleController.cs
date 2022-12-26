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
    public class SVMDServicio_DetalleController : ControllerBase
    {

        IMDServicio_DetalleServices _mDServicio_DetalleServices;

        public SVMDServicio_DetalleController(IMDServicio_DetalleServices mDServicio_DetalleServices)
        {
            _mDServicio_DetalleServices = mDServicio_DetalleServices;
        }

        // GET: api/<SVMDServicio_DetalleController>
        [HttpGet]
        public IEnumerable<MDServicio_Detalle> GetAll()
        {
            return _mDServicio_DetalleServices.GetAll();
        }

        // GET api/<SVMDServicio_DetalleController>/5
        [HttpGet("{id}")]
        public IEnumerable<VMDServicio_Detalle> Getbyid(int id)
        {
            return _mDServicio_DetalleServices.GetbyId(id);
        }

        // POST api/<SVMDServicio_DetalleController>
        [HttpPost]
        public void Post([FromForm] MDServicio_Detalle mDServicio_Detalle)
        {
            if(mDServicio_Detalle.id_servdet == 0)
            {
                _mDServicio_DetalleServices.Save(mDServicio_Detalle);
            }
            else
            {
                _mDServicio_DetalleServices.Update(mDServicio_Detalle);
            }
        }

        // DELETE api/<SVMDServicio_DetalleController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDServicio_DetalleServices.Delete(id);
        }
    }
}
