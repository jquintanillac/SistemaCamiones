using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDRol_PermisosServices
    {
        List<VMRolperm> GetAll();       
        MDRol_Permisos GetbyId(int id_rolperm);
        void Save(MDRol_Permisos oMDRol_Permisos);
        void Update(MDRol_Permisos oMDRol_Permisos);
        string Delete(int id_rolperm);
    }
}
