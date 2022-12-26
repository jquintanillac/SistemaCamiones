using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDProceso_EstadoService : IMDProceso_EstadoServices
    {
        private readonly Datacontext _context;
        public MDProceso_EstadoService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_proest)
        {
            var proest = _context.Proceso_Estados.FirstOrDefault(x => x.id_proest == id_proest);
            if (proest != null)
            {
                _context.Proceso_Estados.Remove(proest);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<VMProcesoEstado> GetAll()
        {
            var vmproest = (from proest in _context.Proceso_Estados
                            join pro in _context.Procesos on proest.id_proces equals pro.id_proces
                            join est in _context.Estado on proest.id_estad equals est.id_estad                            
                            select new VMProcesoEstado
                            {
                               id_proest = proest.id_proest,
                               proces_desc = pro.proces_desc,
                               estad_desc = est.estad_desc,
                               proest_obs = proest.proest_obs
                            }).ToList();
            return vmproest;
        }

        public MDProceso_Estado GetbyId(int id_proest)
        {
            return _context.Proceso_Estados.SingleOrDefault(x => x.id_proest == id_proest);
        }

        public void Save(MDProceso_Estado oProest)
        {
            _context.Proceso_Estados.Add(oProest);
            _context.SaveChanges();
        }

        public void Update(MDProceso_Estado oProest)
        {
            _context.Proceso_Estados.Update(oProest);
            _context.SaveChanges();
        }
    }
}
