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
    public class SVMDSubmenuController : ControllerBase
    {
        IMDSubmenuServices _mDSubmenuServices;

        public SVMDSubmenuController(IMDSubmenuServices mDSubmenuServices)
        {
            _mDSubmenuServices = mDSubmenuServices;
        }

        // GET: api/<SVMDSubmenuController>
        [HttpGet]
        public IEnumerable<VMSubmenu> GetAll()
        {
            return _mDSubmenuServices.GetAll();
        }

        // GET api/<SVMDSubmenuController>/5
        [HttpGet("{id}")]
        public MDSubmenu Getbyid(int id)
        {
            return _mDSubmenuServices.GetbyId(id);
        }

        // POST api/<SVMDSubmenuController>
        [HttpPost]
        public void Post([FromForm] MDSubmenu mDSubmenu)
        {
            if(mDSubmenu.id_menu == 0)
            {
                _mDSubmenuServices.Save(mDSubmenu);
            }
            else
            {
                _mDSubmenuServices.Update(mDSubmenu);   
            }
        }


        // DELETE api/<SVMDSubmenuController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDSubmenuServices.Delete(id);
        }
    }
}
