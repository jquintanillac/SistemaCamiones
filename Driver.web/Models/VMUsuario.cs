using Microsoft.AspNetCore.Http;

namespace Driver.web.Models
{
    public class VMUsuario
    {
        public int IdUsuario { get; set; }
        public string Usua_user { get; set; }
        public string Usua_nombres { get; set; }
        public string Usua_apellidos { get; set; }
        public string Usua_email { get; set; }
        public string Usua_pass { get; set; }
        public string Usua_Hash { get; set; }
        public bool Usua_act { get; set; }
        public IFormFile Usua_imagen { get; set; }
    }
}
