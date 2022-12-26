using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;



namespace Driver.web.Services
{
    public class MDUbigeoService : IMDUbigeoServices
    {
        private readonly Datacontext _context;
        public MDUbigeoService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_ubigeo)
        {
            var ubigeo = _context.Ubigeo.FirstOrDefault(x => x.id_ubigeo == id_ubigeo);
            if (ubigeo != null)
            {
                _context.Ubigeo.Remove(ubigeo);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDUbigeo> GetAll()
        {
            return _context.Ubigeo.ToList();
        }

        public MDUbigeo GetbyId(int id_ubigeo)
        {
            return _context.Ubigeo.SingleOrDefault(x => x.id_ubigeo == id_ubigeo);
        }

        public void Save(MDUbigeo oMDUbigeo)
        {
            MDUbigeo oUbigeo = new MDUbigeo
            {
                ubig_cod = oMDUbigeo.ubig_cod,
                ubig_depa = oMDUbigeo.ubig_depa,
                ubig_prov = oMDUbigeo.ubig_prov,
                ubig_dist = oMDUbigeo.ubig_dist,
                ubig_desc = oMDUbigeo.ubig_depa + "-" + oMDUbigeo.ubig_prov + "-" + oMDUbigeo.ubig_dist

            };
            _context.Ubigeo.Add(oUbigeo);
            _context.SaveChanges();
        }

        public void Update(MDUbigeo oMDUbigeo)
        {
            MDUbigeo oUbigeo = new MDUbigeo
            {
                ubig_cod = oMDUbigeo.ubig_cod,
                ubig_depa = oMDUbigeo.ubig_depa,
                ubig_prov = oMDUbigeo.ubig_prov,
                ubig_dist = oMDUbigeo.ubig_dist,
                ubig_desc = oMDUbigeo.ubig_depa + "-" + oMDUbigeo.ubig_prov + "-" + oMDUbigeo.ubig_dist

            };
            _context.Ubigeo.Update(oUbigeo);
            _context.SaveChanges();
        }
    }
}
