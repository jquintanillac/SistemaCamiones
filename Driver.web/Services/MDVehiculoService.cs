using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDVehiculoService : IMDVehiculoServices
    {
        private readonly Datacontext _context;

        public MDVehiculoService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_vehi)
        {
            var vehic = _context.Vehiculos.FirstOrDefault(x => x.id_vehi == id_vehi);
            if (vehic != null)
            {
                _context.Vehiculos.Remove(vehic);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDVehiculo> GetAll()
        {
            return _context.Vehiculos.ToList();
        }

        public MDVehiculo GetbyId(int id_vehi)
        {
            return _context.Vehiculos.SingleOrDefault(x => x.id_vehi == id_vehi);
        }

        public void Save(MDVehiculo oDVehiculo)
        {
            _context.Vehiculos.Add(oDVehiculo);
            _context.SaveChanges();
        }

        public void Update(MDVehiculo oDVehiculo)
        {
            _context.Vehiculos.Update(oDVehiculo);
            _context.SaveChanges();
        }
    }
}
