using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDRol_UsuarioServices
    {
        List<VMRol_User> GetAll();
        MDRol_Usuario GetbyId(int Idrol_usua);

        void Save(MDRol_Usuario oMDRol_Usuario);
        void Update(MDRol_Usuario oMDRol_Usuario);
        string Delete(int Idrol_usua);
    }
}
