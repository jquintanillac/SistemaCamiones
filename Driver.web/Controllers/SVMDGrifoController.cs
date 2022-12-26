using Driver.web.Data.Entities;
using Driver.web.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDGrifoController : ControllerBase
    {
        IMDGrifoServices _mDGrifoServices;

        public SVMDGrifoController(IMDGrifoServices mDGrifoServices)
        {
            _mDGrifoServices = mDGrifoServices;
        }
        // GET: api/<SVMDClienteController>
        [HttpGet]
        public IEnumerable<MDGrifo> GetAll()
        {
            return _mDGrifoServices.GetAll();
        }

        // GET api/<SVMDClienteController>/5
        [HttpGet("{id}")]
        public MDGrifo Getbyid(int id_grifo)
        {
            return _mDGrifoServices.GetbyId(id_grifo);
        }

        // POST api/<SVMDClienteController>
        [HttpPost]
        public void Post([FromForm] MDGrifo mDGrifo)
        {
            if (mDGrifo.id_grifo == 0)
            {
                _mDGrifoServices.Save(mDGrifo);
            }
            else
            {
                _mDGrifoServices.Update(mDGrifo);
            }
        }

        // DELETE api/<SVMDClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDGrifoServices.Delete(id);
        }
    }
}
