using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDMenuController : ControllerBase
    {
        IMDMenuServices _mDMenuServices;

        public SVMDMenuController(IMDMenuServices mDMenuServices)
        {
            _mDMenuServices = mDMenuServices;
        }

        // GET: api/<SVMDMenuController>
        [HttpGet]
        public IEnumerable<MDMenu> GetAll()
        {
            return _mDMenuServices.GetAll();
        }

        // GET api/<SVMDMenuController>/5
        [HttpGet("{id}")]
        public MDMenu Getbyid(int id)
        {
            return _mDMenuServices.GetbyId(id);
        }

        // POST api/<SVMDMenuController>
        [HttpPost]
        public void Post([FromForm] MDMenu mDMenu)
        {
            if(mDMenu.id_menu == 0)
            {
                _mDMenuServices.Save(mDMenu);
            }
            else
            {
                _mDMenuServices.Update(mDMenu);
            }
        }


        // DELETE api/<SVMDMenuController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDMenuServices.Delete(id);
        }
    }
}
