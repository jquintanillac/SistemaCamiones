using Driver.web.Data.DataSql;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Driver.web.Controllers
{
    public class MDReportesViewController : Controller
    {
        private readonly SP_Reportes _reportes;

        public MDReportesViewController()
        {
            _reportes = new SP_Reportes();
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> rptKardexFisico(DateTime Fecini, DateTime Fecfin)
        {
            DateTime fecha1 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            DateTime fecha2 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");

            if (Fecini == DateTime.MinValue && Fecfin == DateTime.MinValue)
            {
                Fecini = fecha1;
                Fecfin = fecha2;
            }

            ViewBag.rptKardexFisico = await _reportes.rptKardexFisico(Fecini, Fecfin);
            return View();
        }

        public async Task<IActionResult> rptKardexvalorizado(DateTime Fecini, DateTime Fecfin)
        {
            DateTime fecha1 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            DateTime fecha2 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");

            if (Fecini == DateTime.MinValue && Fecfin == DateTime.MinValue)
            {
                Fecini = fecha1;
                Fecfin = fecha2;
            }

            ViewBag.rptKardexvalorizado = await _reportes.rptKardexvalorizado(Fecini, Fecfin);
            return View();
        }

        public async Task<IActionResult> rptServxcamion(DateTime Fecini, DateTime Fecfin)
        {
            DateTime fecha1 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            DateTime fecha2 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");

            if (Fecini == DateTime.MinValue && Fecfin == DateTime.MinValue)
            {
                Fecini = fecha1;
                Fecfin = fecha2;
            }

            ViewBag.rptServxcamion = await _reportes.rptViajexcamion(Fecini, Fecfin);
            return View();
        }

        public async Task<IActionResult> rptServxciudad(DateTime Fecini, DateTime Fecfin)
        {
            DateTime fecha1 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            DateTime fecha2 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");

            if (Fecini == DateTime.MinValue && Fecfin == DateTime.MinValue)
            {
                Fecini = fecha1;
                Fecfin = fecha2;
            }

            ViewBag.rptServxciudad = await _reportes.rptViajexciudad(Fecini, Fecfin);
            return View();
        }


    }
}
