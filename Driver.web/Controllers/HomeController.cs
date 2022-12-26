using Driver.Helpers;
using Driver.web.Data;
using Driver.web.Data.DataSql;
using Driver.web.Data.Entities;
using Driver.web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Driver.web.Controllers
{
    public class HomeController : Controller
    {
        SP_Operaciones sP_Operaciones = new SP_Operaciones();
        private readonly Datacontext _ctx;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, Datacontext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        [BindProperty]
        public MDUsuario Usuario { get; set; }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Login()
        {
            try
            {

                //declaracion de menu y submenu para acceder
                string menu1 = "N";
                string menu2 = "N";
                string menu3 = "N";
                string menu4 = "N";
                string menu5 = "N";
                string menu6 = "N";
                string menu7 = "N";

                //submenu Administracion
                string submenu1_1 = "N";
                string submenu1_2 = "N";
                string submenu1_3 = "N";
                string submenu1_4 = "N";
                string submenu1_5 = "N";
                string submenu1_6 = "N";
                string submenu1_7 = "N";
                string submenu1_8 = "N";
                string submenu1_9 = "N";
                string submenu1_10 = "N";
                string submenu1_11 = "N";
                string submenu1_12 = "N";
                string submenu1_13 = "N";
                string submenu1_14 = "N";
                string submenu1_15 = "N";
                string submenu1_16 = "N";
                string submenu1_17 = "N";
                string submenu1_18 = "N";
                string submenu1_19 = "N";

                //submenu Planificacion
                string submenu2_1 = "N";              
                string submenu2_3 = "N";
                string submenu2_4 = "N";
                string submenu2_5 = "N";
                string submenu2_6 = "N";
                string submenu2_7 = "N";
                string submenu2_8 = "N";
                string submenu2_9 = "N";
                string submenu2_10 = "N";
                string submenu2_11 = "N";

                //submenu Operaciones
                string submenu3_1 = "N";
                string submenu3_2 = "N";

                //submenu Logistica
                string submenu4_1 = "N";
                string submenu4_2 = "N";
                string submenu4_3 = "N";
                string submenu4_4 = "N";    

                //submenu Mantenimiento
                string submenu5_1 = "N";
                string submenu5_2 = "N";
                string submenu5_3 = "N";
                string submenu5_4 = "N";

                //submenu Tesoreria
                string submenu6_1 = "N";
                string submenu6_2 = "N";
                string submenu6_3 = "N";
                string submenu6_4 = "N";

                //submenu Reportes
                string submenu7_1 = "N";
                string submenu7_2 = "N";
                string submenu7_3 = "N";
                string submenu7_4 = "N";
                string submenu7_5 = "N";
                string submenu7_6 = "N";
                string submenu7_7 = "N";


                var xUsuario = await _ctx.Usuario.Where(x => x.Usua_user == Usuario.Usua_user).SingleOrDefaultAsync();
                var role_usr = await _ctx.Rol_Usuario.Where(x => x.IdUsuario == xUsuario.IdUsuario).SingleOrDefaultAsync();
                var rol = await _ctx.Rol.Where(x => x.Idrol == role_usr.Idrol).SingleOrDefaultAsync();
                if ( xUsuario == null)
                {
                    TempData["error"] = "Usuario no existe.";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    if (HashHelper.CheckHash(Usuario.Usua_pass, xUsuario.Usua_pass, xUsuario.Usua_Hash))
                    {
                        var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                        identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, xUsuario.Usua_user.ToString()));
                        identity.AddClaim(new Claim(ClaimTypes.Name, xUsuario.Usua_nombres));
                        identity.AddClaim(new Claim(ClaimTypes.Email, xUsuario.Usua_email));
                        identity.AddClaim(new Claim(ClaimTypes.Role, rol.rol_desc));                       

                        var permisos = await _ctx.Rol_Permisos.Where(x => x.Idrol == rol.Idrol && x.rolperm_act == true).OrderBy(x => x.id_submenu).ToListAsync();

                        foreach (var perm in permisos)
                        {
                            switch (perm.id_menu)
                            {
                                case 1:
                                    var contmenu1 = _ctx.Rol_Permisos.Where(x => x.id_menu == 1 && x.rolperm_act == true && x.Idrol == perm.Idrol).Count();
                                    if (contmenu1 > 0)
                                    {
                                        menu1 = "S";
                                        identity.AddClaim(new Claim("menu1", menu1));
                                    }

                                    if (perm.id_submenu == 1 && perm.rolperm_act == true)
                                    {
                                        submenu1_1 = "S";
                                        identity.AddClaim(new Claim("submenu1_1", submenu1_1));
                                    }

                                    if (perm.id_submenu == 2 && perm.rolperm_act == true)
                                    {
                                        submenu1_2 = "S";
                                        identity.AddClaim(new Claim("submenu1_2", submenu1_2));
                                    }

                                    if (perm.id_submenu == 3 && perm.rolperm_act == true)
                                    {
                                        submenu1_3 = "S";
                                        identity.AddClaim(new Claim("submenu1_3", submenu1_3));
                                    }

                                    if (perm.id_submenu == 4 && perm.rolperm_act == true)
                                    {
                                        submenu1_4 = "S";
                                        identity.AddClaim(new Claim("submenu1_4", submenu1_4));
                                    }
                                    if (perm.id_submenu == 5 && perm.rolperm_act == true)
                                    {
                                        submenu1_5 = "S";
                                        identity.AddClaim(new Claim("submenu1_5", submenu1_5));
                                    }

                                    if (perm.id_submenu == 6 && perm.rolperm_act == true)
                                    {
                                        submenu1_6 = "S";
                                        identity.AddClaim(new Claim("submenu1_6", submenu1_6));
                                    }

                                    if (perm.id_submenu == 7 && perm.rolperm_act == true)
                                    {
                                        submenu1_7 = "S";
                                        identity.AddClaim(new Claim("submenu1_7", submenu1_7));
                                    }

                                    if (perm.id_submenu == 8 && perm.rolperm_act == true)
                                    {
                                        submenu1_8 = "S";
                                        identity.AddClaim(new Claim("submenu1_8", submenu1_8));
                                    }

                                    if (perm.id_submenu == 9 && perm.rolperm_act == true)
                                    {
                                        submenu1_9 = "S";
                                        identity.AddClaim(new Claim("submenu1_9", submenu1_9));
                                    }

                                    if (perm.id_submenu == 10 && perm.rolperm_act == true)
                                    {
                                        submenu1_10 = "S";
                                        identity.AddClaim(new Claim("submenu1_10", submenu1_10));
                                    }

                                    if (perm.id_submenu == 11 && perm.rolperm_act == true)
                                    {
                                        submenu1_11 = "S";
                                        identity.AddClaim(new Claim("submenu1_11", submenu1_11));
                                    }

                                    if (perm.id_submenu == 12 && perm.rolperm_act == true)
                                    {
                                        submenu1_12 = "S";
                                        identity.AddClaim(new Claim("submenu1_12", submenu1_12));
                                    }

                                    if (perm.id_submenu == 13 && perm.rolperm_act == true)
                                    {
                                        submenu1_13 = "S";
                                        identity.AddClaim(new Claim("submenu1_13", submenu1_13));
                                    }
                                    if (perm.id_submenu == 14 && perm.rolperm_act == true)
                                    {
                                        submenu1_14 = "S";
                                        identity.AddClaim(new Claim("submenu1_14", submenu1_14));
                                    }

                                    if (perm.id_submenu == 15 && perm.rolperm_act == true)
                                    {
                                        submenu1_15 = "S";
                                        identity.AddClaim(new Claim("submenu1_15", submenu1_15));
                                    }

                                    if (perm.id_submenu == 16 && perm.rolperm_act == true)
                                    {
                                        submenu1_16 = "S";
                                        identity.AddClaim(new Claim("submenu1_16", submenu1_16));
                                    }

                                    if (perm.id_submenu == 17 && perm.rolperm_act == true)
                                    {
                                        submenu1_17 = "S";
                                        identity.AddClaim(new Claim("submenu1_17", submenu1_17));
                                    }

                                    if (perm.id_submenu == 18 && perm.rolperm_act == true)
                                    {
                                        submenu1_18 = "S";
                                        identity.AddClaim(new Claim("submenu1_18", submenu1_18));
                                    }
                                    if (perm.id_submenu == 53 && perm.rolperm_act == true)
                                    {
                                        submenu1_19 = "S";
                                        identity.AddClaim(new Claim("submenu1_19", submenu1_19));
                                    }

                                    break;
                                case 2:
                                    var contmenu2 = _ctx.Rol_Permisos.Where(x => x.id_menu == 2 && x.rolperm_act == true && x.Idrol == perm.Idrol).Count();
                                    if (contmenu2 > 0)
                                    {
                                        menu2 = "S";
                                        identity.AddClaim(new Claim("menu2", menu2));
                                    }

                                    if (perm.id_submenu == 12 && perm.rolperm_act == true)
                                    {
                                        submenu2_1 = "S";
                                        identity.AddClaim(new Claim("submenu2_1", submenu2_1));
                                    }
                                    if (perm.id_submenu == 14 && perm.rolperm_act == true)
                                    {
                                        submenu2_3 = "S";
                                        identity.AddClaim(new Claim("submenu2_3", submenu2_3));
                                    }

                                    if (perm.id_submenu == 15 && perm.rolperm_act == true)
                                    {
                                        submenu2_4 = "S";
                                        identity.AddClaim(new Claim("submenu2_4", submenu2_4));
                                    }

                                    if (perm.id_submenu == 16 && perm.rolperm_act == true)
                                    {
                                        submenu2_5 = "S";
                                        identity.AddClaim(new Claim("submenu2_5", submenu2_5));
                                    }
                                    if (perm.id_submenu == 17 && perm.rolperm_act == true)
                                    {
                                        submenu2_6 = "S";
                                        identity.AddClaim(new Claim("submenu2_6", submenu2_6));
                                    }
                                    if (perm.id_submenu == 46 && perm.rolperm_act == true)
                                    {
                                        submenu2_7 = "S";
                                        identity.AddClaim(new Claim("submenu2_7", submenu2_7));
                                    }
                                    if (perm.id_submenu == 47 && perm.rolperm_act == true)
                                    {
                                        submenu2_8 = "S";
                                        identity.AddClaim(new Claim("submenu2_8", submenu2_8));
                                    }
                                    if (perm.id_submenu == 48 && perm.rolperm_act == true)
                                    {
                                        submenu2_9 = "S";
                                        identity.AddClaim(new Claim("submenu2_9", submenu2_9));
                                    }
                                    if (perm.id_submenu == 49 && perm.rolperm_act == true)
                                    {
                                        submenu2_10 = "S";
                                        identity.AddClaim(new Claim("submenu2_10", submenu2_10));
                                    }
                                    if (perm.id_submenu == 50 && perm.rolperm_act == true)
                                    {
                                        submenu2_11 = "S";
                                        identity.AddClaim(new Claim("submenu2_11", submenu2_11));
                                    }

                                    break;
                                case 3:
                                    var contmenu3 = _ctx.Rol_Permisos.Where(x => x.id_menu == 3 && x.rolperm_act == true && x.Idrol == perm.Idrol).Count();
                                    if (contmenu3 > 0)
                                    {
                                        menu3 = "S";
                                        identity.AddClaim(new Claim("menu3", menu3));
                                    }

                                    if (perm.id_submenu == 18 && perm.rolperm_act == true)
                                    {
                                        submenu3_1 = "S";
                                        identity.AddClaim(new Claim("submenu3_1", submenu3_1));
                                    }

                                    if (perm.id_submenu == 19 && perm.rolperm_act == true)
                                    {
                                        submenu3_2 = "S";
                                        identity.AddClaim(new Claim("submenu3_2", submenu3_2));
                                    }
                                    
                                    break;
                                case 4:
                                    var contmenu4 = _ctx.Rol_Permisos.Where(x => x.id_menu == 4 && x.rolperm_act == true && x.Idrol == perm.Idrol).Count();
                                    if (contmenu4 > 0)
                                    {
                                        menu4 = "S";
                                        identity.AddClaim(new Claim("menu4", menu4));
                                    }

                                    if (perm.id_submenu == 20 && perm.rolperm_act == true)
                                    {
                                        submenu4_1 = "S";
                                        identity.AddClaim(new Claim("submenu4_1", submenu4_1));
                                    }

                                    if (perm.id_submenu == 21 && perm.rolperm_act == true)
                                    {
                                        submenu4_2 = "S";
                                        identity.AddClaim(new Claim("submenu4_2", submenu4_2));
                                    }
                                    if (perm.id_submenu == 22 && perm.rolperm_act == true)
                                    {
                                        submenu4_3 = "S";
                                        identity.AddClaim(new Claim("submenu4_3", submenu4_3));
                                    }
                                    if (perm.id_submenu == 45 && perm.rolperm_act == true)
                                    {
                                        submenu4_4 = "S";
                                        identity.AddClaim(new Claim("submenu4_4", submenu4_4));
                                    }

                                    break;
                                case 5:
                                    var contmenu5 = _ctx.Rol_Permisos.Where(x => x.id_menu == 5 && x.rolperm_act == true && x.Idrol == perm.Idrol).Count();
                                    if (contmenu5 > 0)
                                    {
                                        menu5 = "S";
                                        identity.AddClaim(new Claim("menu5", menu5));
                                    }

                                    if (perm.id_submenu == 23 && perm.rolperm_act == true)
                                    {
                                        submenu5_1 = "S";
                                        identity.AddClaim(new Claim("submenu5_1", submenu5_1));
                                    }

                                    if (perm.id_submenu == 24 && perm.rolperm_act == true)
                                    {
                                        submenu5_2 = "S";
                                        identity.AddClaim(new Claim("submenu5_2", submenu5_2));
                                    }

                                    if (perm.id_submenu == 51 && perm.rolperm_act == true)
                                    {
                                        submenu5_3 = "S";
                                        identity.AddClaim(new Claim("submenu5_3", submenu5_3));
                                    }
                                    if (perm.id_submenu == 52 && perm.rolperm_act == true)
                                    {
                                        submenu5_4 = "S";
                                        identity.AddClaim(new Claim("submenu5_4", submenu5_4));
                                    }

                                    break;

                                case 6:
                                    var contmenu6 = _ctx.Rol_Permisos.Where(x => x.id_menu == 6 && x.rolperm_act == true && x.Idrol == perm.Idrol).Count();
                                    if (contmenu6 > 0)
                                    {
                                        menu6 = "S";
                                        identity.AddClaim(new Claim("menu6", menu6));
                                    }

                                    if (perm.id_submenu == 25 && perm.rolperm_act == true)
                                    {
                                        submenu6_1 = "S";
                                        identity.AddClaim(new Claim("submenu6_1", submenu6_1));
                                    }
                                    if (perm.id_submenu == 26 && perm.rolperm_act == true)
                                    {
                                        submenu6_2 = "S";
                                        identity.AddClaim(new Claim("submenu6_2", submenu6_2));
                                    }
                                    if (perm.id_submenu == 27 && perm.rolperm_act == true)
                                    {
                                        submenu6_3 = "S";
                                        identity.AddClaim(new Claim("submenu6_3", submenu6_3));
                                    }
                                    if (perm.id_submenu == 28 && perm.rolperm_act == true)
                                    {
                                        submenu6_4 = "S";
                                        identity.AddClaim(new Claim("submenu6_4", submenu6_4));
                                    }

                                    break;
                                case 7:
                                    var contmenu7 = _ctx.Rol_Permisos.Where(x => x.id_menu == 7 && x.rolperm_act == true && x.Idrol == perm.Idrol).Count();
                                    if (contmenu7 > 0)
                                    {
                                        menu7 = "S";
                                        identity.AddClaim(new Claim("menu7", menu7));
                                    }

                                    if (perm.id_submenu == 29 && perm.rolperm_act == true)
                                    {
                                        submenu7_1 = "S";
                                        identity.AddClaim(new Claim("submenu7_1", submenu7_1));
                                    }
                                    if (perm.id_submenu == 30 && perm.rolperm_act == true)
                                    {
                                        submenu7_2 = "S";
                                        identity.AddClaim(new Claim("submenu7_2", submenu7_2));
                                    }
                                    if (perm.id_submenu == 31 && perm.rolperm_act == true)
                                    {
                                        submenu7_3 = "S";
                                        identity.AddClaim(new Claim("submenu7_3", submenu7_3));
                                    }
                                    if (perm.id_submenu == 32 && perm.rolperm_act == true)
                                    {
                                        submenu7_4 = "S";
                                        identity.AddClaim(new Claim("submenu7_4", submenu7_4));
                                    }
                                    if (perm.id_submenu == 33 && perm.rolperm_act == true)
                                    {
                                        submenu7_5 = "S";
                                        identity.AddClaim(new Claim("submenu7_5", submenu7_5));
                                    }
                                    if (perm.id_submenu == 34 && perm.rolperm_act == true)
                                    {
                                        submenu7_6 = "S";
                                        identity.AddClaim(new Claim("submenu7_6", submenu7_6));
                                    }
                                    if (perm.id_submenu == 35 && perm.rolperm_act == true)
                                    {
                                        submenu7_7 = "S";
                                        identity.AddClaim(new Claim("submenu7_7", submenu7_7));
                                    }
                                    break;
                            }
                        }
                        var principal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
                        new AuthenticationProperties { ExpiresUtc = DateTime.Now.AddDays(2), IsPersistent = true });
                        return RedirectToAction("Inicio", "Home");
                    }
                    else
                    {
                        TempData["error"] = "Contrasena incorrecta.";
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }


        public async Task<IActionResult> Registrar()
        {
            try
            {
                var result = await _ctx.Usuario.Where(x => x.Usua_user == Usuario.Usua_user).SingleOrDefaultAsync();
                if (result != null)
                {
                    TempData["error"] = "Usuario ya existe.";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    var hash = HashHelper.Hash(Usuario.Usua_pass);                   

                    MDUsuario dUsuario = new MDUsuario
                    {
                        Usua_user = Usuario.Usua_user,
                        Usua_nombres = Usuario.Usua_nombres,
                        Usua_apellidos = Usuario.Usua_apellidos,
                        Usua_email = Usuario.Usua_email,
                        Usua_pass = hash.Password,
                        Usua_Hash = hash.Salt,
                        Usua_act = true

                    };

                    _ctx.Usuario.Add(dUsuario);
                    await _ctx.SaveChangesAsync();
                    TempData["success"] = "Usuario creado exitosamente.";
                    return RedirectToAction("Index", "Home");
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
