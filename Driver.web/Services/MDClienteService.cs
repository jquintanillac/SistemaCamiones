using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDClienteService : IMDClienteServices
    {
        private readonly Datacontext _context;

        public MDClienteService(Datacontext context)
        {
            _context = context;
        }
        public string Delete(int id_cliente)
        {
            var cliente = _context.Cliente.FirstOrDefault(x => x.id_cliente == id_cliente);
            if (cliente != null)
            {
                _context.Cliente.Remove(cliente);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDCliente> GetAll()
        {
            return _context.Cliente.ToList();
        }

        public MDCliente GetbyId(int id_cliente)
        {
            return _context.Cliente.SingleOrDefault(x => x.id_cliente == id_cliente);
        }

        public void Save(MDCliente oMDCliente)
        {
            _context.Cliente.Add(oMDCliente);
            _context.SaveChanges();
        }

        public void Update(MDCliente oMDCliente)
        {
            _context.Cliente.Update(oMDCliente);
            _context.SaveChanges();
        }
    }
}
