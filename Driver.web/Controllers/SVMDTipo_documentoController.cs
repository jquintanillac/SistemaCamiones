using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDTipo_documentoController : ControllerBase
    {
        IMDTipo_documentoServices _mDTipo_DocumentoServices;

        public SVMDTipo_documentoController(IMDTipo_documentoServices mDTipo_DocumentoServices)
        {
            _mDTipo_DocumentoServices = mDTipo_DocumentoServices;
        }

        // GET: api/<SVMDTipo_documentoController>
        [HttpGet]
        public IEnumerable<MDTipo_documento> GetAll()
        {
            return _mDTipo_DocumentoServices.GetAll();
        }

        // GET api/<SVMDTipo_documentoController>/5
        [HttpGet("{id}")]
        public MDTipo_documento Getbyid(int id)
        {
            return _mDTipo_DocumentoServices.GetbyId(id);
        }

        // POST api/<SVMDTipo_documentoController>
        [HttpPost]
        public void Post([FromForm] MDTipo_documento mDTipo_Documento)
        {
            if(mDTipo_Documento.id_tipdoc == 0)
            {
                _mDTipo_DocumentoServices.Save(mDTipo_Documento);
            }
            else
            {
                _mDTipo_DocumentoServices.Update(mDTipo_Documento);
            }
        }


        // DELETE api/<SVMDTipo_documentoController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDTipo_DocumentoServices.Delete(id);
        }
    }
}
