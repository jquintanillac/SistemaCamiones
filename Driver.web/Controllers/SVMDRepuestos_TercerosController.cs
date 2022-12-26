using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDRepuestos_TercerosController : ControllerBase
    {
        IMDRepuestos_TercerosServices _TercerosServices;

        public SVMDRepuestos_TercerosController(IMDRepuestos_TercerosServices TercerosServices)
        {
            _TercerosServices = TercerosServices;
        }
        // GET: api/<SVMDClienteController>
        [HttpGet]
        public IEnumerable<VMDRepuestos_Terceros> GetAll()
        {
            return _TercerosServices.GetAll();
        }

        // GET api/<SVMDClienteController>/5
        [HttpGet("{id}")]
        public MDRepuestos_Terceros Getbyid(int id_repter)
        {
            return _TercerosServices.GetbyId(id_repter);
        }

        // POST api/<SVMDClienteController>
        [HttpPost]
        public void Post([FromForm] MDRepuestos_Terceros oReputer)
        {
            if (oReputer.id_repter == 0)
            {
                _TercerosServices.Save(oReputer);
            }
            else
            {
                _TercerosServices.Update(oReputer);
            }
        }

        // DELETE api/<SVMDClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _TercerosServices.Delete(id);
        }
    }
}
