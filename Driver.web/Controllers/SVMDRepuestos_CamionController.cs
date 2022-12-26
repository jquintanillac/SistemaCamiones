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
    public class SVMDRepuestos_CamionController : ControllerBase
    {
        IMDRepuestos_CamionServices _mDRepuestos_CamionServices;

        public SVMDRepuestos_CamionController(IMDRepuestos_CamionServices mDRepuestos_CamionServices)
        {
            _mDRepuestos_CamionServices = mDRepuestos_CamionServices;
        }

        // GET: api/<SVMDRepuestos_CamionController>
        [HttpGet]
        public IEnumerable<VMDRepuestos_Camion> GetAll()
        {
            return _mDRepuestos_CamionServices.GetAll();
        }

        // GET api/<SVMDRepuestos_CamionController>/5
        [HttpGet("{id}")]
        public MDRepuestos_Camion Getbyid(int id)
        {
            return _mDRepuestos_CamionServices.GetbyId(id);
        }

        // POST api/<SVMDRepuestos_CamionController>
        [HttpPost]
        public void Post([FromForm] MDRepuestos_Camion mDRepuestos_Camion)
        {
            if(mDRepuestos_Camion.id_repcam == 0)
            {
                _mDRepuestos_CamionServices.Save(mDRepuestos_Camion);
            }
            else
            {
                _mDRepuestos_CamionServices.Update(mDRepuestos_Camion);
            }
        }


        // DELETE api/<SVMDRepuestos_CamionController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDRepuestos_CamionServices.Delete(id);
        }
    }
}
