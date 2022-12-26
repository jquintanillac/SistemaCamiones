using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDTipo_camionController : ControllerBase
    {
        IMDTipo_camionServices _CamionServices;

        public SVMDTipo_camionController(IMDTipo_camionServices CamionServices)
        {
            _CamionServices = CamionServices;
        }

        // GET: api/<SVMDClienteController>
        [HttpGet]
        public IEnumerable<MDTipo_camion> GetAll()
        {
            return _CamionServices.GetAll();
        }

        // GET api/<SVMDClienteController>/5
        [HttpGet("{id}")]
        public MDTipo_camion Getbyid(int id_Tipcam)
        {
            return _CamionServices.GetbyId(id_Tipcam);
        }

        // POST api/<SVMDClienteController>
        [HttpPost]
        public void Post([FromForm] MDTipo_camion mDTipo)
        {
            if (mDTipo.id_Tipcam == 0)
            {
                _CamionServices.Save(mDTipo);
            }
            else
            {
                _CamionServices.Update(mDTipo);
            }
        }

        // DELETE api/<SVMDClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _CamionServices.Delete(id);
        }
    }
}
