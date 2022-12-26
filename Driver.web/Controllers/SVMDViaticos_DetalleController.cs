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
    public class SVMDViaticos_DetalleController : ControllerBase
    {
        IMDViaticos_DetalleServices _mDViaticos_DetalleServices;

        public SVMDViaticos_DetalleController(IMDViaticos_DetalleServices mDViaticos_DetalleServices)
        {
            _mDViaticos_DetalleServices = mDViaticos_DetalleServices;   
        }

        // GET: api/<SVMDViaticos_DetalleController>
        [HttpGet]
        public IEnumerable<MDViaticos_Detalle> GetAll()
        {
            return _mDViaticos_DetalleServices.GetAll();
        }

        // GET api/<SVMDViaticos_DetalleController>/5
        [HttpGet("{id}")]
        public List<VMViatico_Detalle> Getbyid(int id)
        {
            return _mDViaticos_DetalleServices.GetbyId(id);
        }

        // POST api/<SVMDViaticos_DetalleController>
        [HttpPost]
        public void Post([FromForm] MDViaticos_Detalle mDViaticos_Detalle)
        {
            if(mDViaticos_Detalle.id_viatdet == 0)
            {
                _mDViaticos_DetalleServices.Save(mDViaticos_Detalle);
            }
            else
            {
                _mDViaticos_DetalleServices.Update(mDViaticos_Detalle);
            }
        }

        // DELETE api/<SVMDViaticos_DetalleController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDViaticos_DetalleServices.Delete(id);
        }
    }
}
