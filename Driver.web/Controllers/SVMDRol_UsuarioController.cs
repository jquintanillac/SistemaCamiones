using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;
using Driver.web.Models;
using Driver.web.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDRol_UsuarioController : ControllerBase
    {
        IMDRol_UsuarioServices _mDRol_UsuarioServices;
        public SVMDRol_UsuarioController(IMDRol_UsuarioServices mDRol_UsuarioServices)
        {
            _mDRol_UsuarioServices = mDRol_UsuarioServices;
        }

        // GET: api/<SVMDRol_UsuarioController>
        [HttpGet]
        public IEnumerable<VMRol_User> GetAll()
        {
            return _mDRol_UsuarioServices.GetAll();
        }

        // GET api/<SVMDRol_UsuarioController>/5
        [HttpGet("{id}")]
        public MDRol_Usuario Getbyid(int id)
        {
            return _mDRol_UsuarioServices.GetbyId(id);
        }

        // POST api/<SVMDRol_UsuarioController>
        [HttpPost]
        public void Post([FromForm] MDRol_Usuario mDRol_Usuario)
        {
            if(mDRol_Usuario.Idrol_usua == 0)
            {
                _mDRol_UsuarioServices.Save(mDRol_Usuario);
            }
            else
            {
                _mDRol_UsuarioServices.Update(mDRol_Usuario);
            }
        }

        // DELETE api/<SVMDRol_UsuarioController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDRol_UsuarioServices.Delete(id);   
        }
    }
}
