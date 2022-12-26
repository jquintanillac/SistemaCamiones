using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDEspecialidadService : IMDEspecialidadServices
    {
        private readonly Datacontext _context;

        public MDEspecialidadService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_espec)
        {
            var chofer = _context.Especialidades.FirstOrDefault(x => x.id_espec == id_espec);
            if (chofer != null)
            {
                _context.Especialidades.Remove(chofer);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDEspecialidad> GetAll()
        {
            return _context.Especialidades.ToList();
        }

        public MDEspecialidad GetbyId(int id_espec)
        {
            return _context.Especialidades.SingleOrDefault(x => x.id_espec == id_espec);
        }

        public void Save(MDEspecialidad oMDespecial)
        {
            _context.Especialidades.Add(oMDespecial);
            _context.SaveChanges();
        }

        public void Update(MDEspecialidad oMDespecial)
        {
            _context.Especialidades.Update(oMDespecial);
            _context.SaveChanges();
        }
    }
}
