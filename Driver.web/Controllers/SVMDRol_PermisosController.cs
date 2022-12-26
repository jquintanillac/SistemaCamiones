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
    public class SVMDRol_PermisosController : ControllerBase
    {
        IMDRol_PermisosServices _mDRol_PermisosServices;

        public SVMDRol_PermisosController(IMDRol_PermisosServices mDRol_PermisosServices)
        {
            _mDRol_PermisosServices = mDRol_PermisosServices;   
        }

        // GET: api/<SVMDRol_PermisosController>
        [HttpGet]
        public IEnumerable<VMRolperm> GetAll()
        {
            return _mDRol_PermisosServices.GetAll();
        }

        // GET api/<SVMDRol_PermisosController>/5
        [HttpGet("{id}")]
        public MDRol_Permisos Getbyid(int id)
        {
            return _mDRol_PermisosServices.GetbyId(id);
        }

        // POST api/<SVMDRol_PermisosController>
        [HttpPost]
        public void Post([FromForm] MDRol_Permisos mDRol_Permisos)
        {
            if(mDRol_Permisos.id_rolperm == 0)
            {
                _mDRol_PermisosServices.Save(mDRol_Permisos);
            }
            else
            {
                _mDRol_PermisosServices.Update(mDRol_Permisos);
            }
        }


        // DELETE api/<SVMDRol_PermisosController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDRol_PermisosServices.Delete(id);
        }
    }
}
