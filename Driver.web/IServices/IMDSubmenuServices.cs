using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDSubmenuServices
    {
        List<VMSubmenu> GetAll();
        MDSubmenu GetbyId(int id_submenu);
        void Save(MDSubmenu oMDSubmenu);
        void Update(MDSubmenu oMDSubmenu);
        string Delete(int id_submenu);
    }
}
