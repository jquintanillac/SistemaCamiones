using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDCondicion_ContractualService : IMDCondicion_ContractualServices
    {
        private readonly Datacontext _context;

        public MDCondicion_ContractualService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_concontrac)
        {
            var contra = _context.Condicion_Contractuales.FirstOrDefault(x => x.id_concontrac == id_concontrac);
            if (contra != null)
            {
                _context.Condicion_Contractuales.Remove(contra);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDCondicion_Contractual> GetAll()
        {
            return _context.Condicion_Contractuales.ToList();
        }

        public MDCondicion_Contractual GetbyId(int id_concontrac)
        {
            return _context.Condicion_Contractuales.SingleOrDefault(x => x.id_concontrac == id_concontrac);
        }

        public void Save(MDCondicion_Contractual oCondcontra)
        {
            _context.Condicion_Contractuales.Add(oCondcontra);
            _context.SaveChanges();
        }

        public void Update(MDCondicion_Contractual oCondcontra)
        {
            _context.Condicion_Contractuales.Update(oCondcontra);
            _context.SaveChanges();
        }
    }
}
