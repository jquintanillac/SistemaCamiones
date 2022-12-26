using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;


namespace Driver.web.Services
{
    public class MDCombustibleService : IMDCombustibleServices
    {
        private readonly Datacontext _context;

        public MDCombustibleService(Datacontext context)
        {
            _context = context;
        }
        public string Delete(int id_combu)
        {
            var combu = _context.Combustibles.FirstOrDefault(x => x.id_combu == id_combu);
            if (combu != null)
            {
                _context.Combustibles.Remove(combu);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public MDCombustible GetbyId(int id_combu)
        {
            return _context.Combustibles.SingleOrDefault(x => x.id_combu == id_combu);
        }

        public List<VMDCombustible> GetAll()
        {
            var vmcombu = (from combu in _context.Combustibles
                           join placa in _context.Vehiculos on combu.id_vehi equals placa.id_vehi
                           join grif in _context.Grifos on combu.id_grifo equals grif.id_grifo
                           select new VMDCombustible
                           {
                               id_combu = combu.id_combu,
                               id_vehi = combu.id_vehi,
                               id_grifo = combu.id_grifo,
                               vehi_placa = placa.vehi_placa,                              
                               grifo_descr = grif.grifo_descr,
                               combu_obs = combu.combu_obs,
                               combu_fecreg = combu.combu_fecreg,
                               combu_cant = combu.combu_cant,
                               combu_prec = combu.combu_prec
                           }).ToList();
            return vmcombu;
        }

        public void Save(MDCombustible oMDCombustible)
        {
            _context.Combustibles.Add(oMDCombustible);
            _context.SaveChanges();
        }

        public void Update(MDCombustible oMDCombustible)
        {
            _context.Combustibles.Update(oMDCombustible);
            _context.SaveChanges();
        }
    }
}
