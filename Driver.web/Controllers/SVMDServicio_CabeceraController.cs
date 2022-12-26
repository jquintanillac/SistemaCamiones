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
    public class SVMDServicio_CabeceraController : ControllerBase
    {
        IMDServicio_CabeceraServices _mDServicio_CabeceraServices;

        public SVMDServicio_CabeceraController(IMDServicio_CabeceraServices mDServicio_CabeceraServices)
        {
            _mDServicio_CabeceraServices = mDServicio_CabeceraServices;
        }

        // GET: api/<SVMDServicio_CabeceraController>
        [HttpGet]
        public IEnumerable<VMDServicio_Cabecera> GetAll()
        {
            return _mDServicio_CabeceraServices.GetAll();
        }

        // GET api/<SVMDServicio_CabeceraController>/5
        [HttpGet("{id}")]
        public MDServicio_Cabecera Getbyid(int id)
        {
            return _mDServicio_CabeceraServices.GetbyId(id);
        }

        // POST api/<SVMDServicio_CabeceraController>
        [HttpPost]
        public void Post([FromForm] VMDServicio_Cabecera mDServicio_Cabecera)
        {
            if(mDServicio_Cabecera.id_servcab == 0)
            {
                _mDServicio_CabeceraServices.Save(mDServicio_Cabecera);
            }
            else
            {
                _mDServicio_CabeceraServices.Update(mDServicio_Cabecera);
            }
        }


        // DELETE api/<SVMDServicio_C-abeceraController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDServicio_CabeceraServices.Delete(id);
        }
    }
}
