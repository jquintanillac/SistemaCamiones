using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDMenuServices
    {
        List<MDMenu> GetAll();
        MDMenu GetbyId(int id_menu);

        void Save(MDMenu oMDMenu);
        void Update(MDMenu oMDMenu);
        string Delete(int id_menu);
    }
}
