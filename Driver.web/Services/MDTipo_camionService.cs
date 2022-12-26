using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDTipo_camionService : IMDTipo_camionServices
    {
        private readonly Datacontext _context;

        public MDTipo_camionService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_Tipcam)
        {
            var tipcam = _context.Tipo_Camiones.FirstOrDefault(x => x.id_Tipcam == id_Tipcam);
            if (tipcam != null)
            {
                _context.Tipo_Camiones.Remove(tipcam);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDTipo_camion> GetAll()
        {
            return _context.Tipo_Camiones.ToList();
        }

        public MDTipo_camion GetbyId(int id_Tipcam)
        {
            return _context.Tipo_Camiones.SingleOrDefault(x => x.id_Tipcam == id_Tipcam);
        }

        public void Save(MDTipo_camion oDTipo_Camion)
        {
            _context.Tipo_Camiones.Add(oDTipo_Camion);
            _context.SaveChanges();
        }

        public void Update(MDTipo_camion oDTipo_Camion)
        {
            _context.Tipo_Camiones.Update(oDTipo_Camion);
            _context.SaveChanges();
        }
    }
}
