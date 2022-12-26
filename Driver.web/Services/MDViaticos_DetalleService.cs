using Driver.web.Data;
using Driver.web.Data.DataSql;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;


namespace Driver.web.Services
{
    public class MDViaticos_DetalleService : IMDViaticos_DetalleServices
    {
        private readonly Datacontext _context;
        private readonly SP_Operaciones _Operaciones;
        public MDViaticos_DetalleService(Datacontext context)
        {
            _context = context;
            _Operaciones = new SP_Operaciones();
        }

        public string Delete(int id_viatdet)
        {
            var viaydet = _context.Viaticos_Detalle.FirstOrDefault(x => x.id_viatdet == id_viatdet);
            if (viaydet != null)
            {
                _context.Viaticos_Detalle.Remove(viaydet);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDViaticos_Detalle> GetAll()
        {
            return _context.Viaticos_Detalle.ToList();
        }

        public List<VMViatico_Detalle> GetbyId(int id_viatcab)
        {
            var vmviatdet = (from viatdet in _context.Viaticos_Detalle
                             join chof in _context.Chofer on viatdet.id_chofer equals chof.id_chofer
                             where viatdet.id_viatcab == id_viatcab
                             select new VMViatico_Detalle
                             {
                               id_viatdet = viatdet.id_viatdet,
                               id_viatcab = viatdet.id_viatcab,
                               id_chofer = viatdet.id_chofer,
                               chof_nomcomp = chof.chofer_nombre + " " + chof.chofer_apellido,
                               viatdet_concep = viatdet.viatdet_concep,
                               viatdet_monuni = viatdet.viatdet_monuni,
                               viatdet_fecini = viatdet.viatdet_fecini,
                               viajdet_fecfin = viatdet.viajdet_fecfin
                             }).ToList();
            return vmviatdet;
        }

        public void Save(MDViaticos_Detalle oMDViaticos_Detalle)
        {
            _context.Viaticos_Detalle.Add(oMDViaticos_Detalle);
            _context.SaveChanges();
            _Operaciones.mUpdateViatcab(oMDViaticos_Detalle.id_viatcab);

        }

        public void Update(MDViaticos_Detalle oMDViaticos_Detalle)
        {
            _context.Viaticos_Detalle.Update(oMDViaticos_Detalle);
            _context.SaveChanges();
            _Operaciones.mUpdateViatcab(oMDViaticos_Detalle.id_viatcab);
        }
    }
}
