using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Data;
using Driver.web.Models;



namespace Driver.web.Data.DataSql
{
    public class SP_Reportes
    {
        public SqlConnection conex;
        public SP_Reportes()
        {
            var config = GetConfiguration();
            conex = new SqlConnection(config.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);
        }

        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<VMKardex_Fisico>> rptKardexFisico(DateTime fecini, DateTime fecfin)
        {
            try
            {
                List<VMKardex_Fisico> Lstkarfis = new List<VMKardex_Fisico>();
                SqlCommand cmd = new SqlCommand("[DBO].[SP_REPORTE_KARDEX_Q01]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FECINI", fecini);
                cmd.Parameters.AddWithValue("@FECFIN", fecfin);
                conex.Open();
                SqlDataReader rdr = await cmd.ExecuteReaderAsync();
                while (rdr.Read())
                {
                    VMKardex_Fisico objkar = new VMKardex_Fisico();
                    objkar.product_descr = rdr["product_descr"].ToString();
                    objkar.repus_cant = rdr["repus_cant"].ToString();
                    objkar.repus_fecing = rdr["repus_fecing"].ToString();
                    objkar.repcam_fecreg = rdr["repcam_fecreg"].ToString();
                    Lstkarfis.Add(objkar);
                }
                conex.Close();
                return Lstkarfis;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<VMKardex_Valorizado>> rptKardexvalorizado(DateTime fecini, DateTime fecfin)
        {
            try
            {
                List<VMKardex_Valorizado> Lstkarfis = new List<VMKardex_Valorizado>();
                SqlCommand cmd = new SqlCommand("[DBO].[SP_REPORTE_KARDEX_Q02]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FECINI", fecini);
                cmd.Parameters.AddWithValue("@FECFIN", fecfin);
                conex.Open();
                SqlDataReader rdr = await cmd.ExecuteReaderAsync();
                while (rdr.Read())
                {
                    VMKardex_Valorizado objkar = new VMKardex_Valorizado();
                    objkar.product_descr = rdr["product_descr"].ToString();
                    objkar.repus_cant = rdr["repus_cant"].ToString();
                    objkar.repus_preuni = rdr["repus_preuni"].ToString();
                    objkar.repus_fecing = rdr["repus_fecing"].ToString();
                    objkar.repcam_fecreg = rdr["repcam_fecreg"].ToString();
                    Lstkarfis.Add(objkar);
                }
                conex.Close();
                return Lstkarfis;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<VMServicios_camiones>> rptViajexcamion(DateTime fecini, DateTime fecfin)
        {
            try
            {
                List<VMServicios_camiones> Lstviaj = new List<VMServicios_camiones>();
                SqlCommand cmd = new SqlCommand("[DBO].[SP_REPORTE_VIAJE_Q01]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FECINI", fecini);
                cmd.Parameters.AddWithValue("@FECFIN", fecfin);
                conex.Open();
                SqlDataReader rdr = await cmd.ExecuteReaderAsync();
                while (rdr.Read())
                {
                    VMServicios_camiones objviaj = new VMServicios_camiones();
                    objviaj.vehi_placa = rdr["vehi_placa"].ToString();
                    objviaj.chofer_nombre = rdr["chofer_nombre"].ToString();
                    objviaj.chofer_apellido = rdr["chofer_apellido"].ToString();
                    objviaj.servcab_nro = rdr["servcab_nro"].ToString();
                    objviaj.servcab_desc = rdr["servcab_desc"].ToString();
                    objviaj.servcab_fec = rdr["servcab_fec"].ToString();
                    objviaj.servcab_canttotal = rdr["servcab_canttotal"].ToString();
                    objviaj.servcab_montotal = rdr["servcab_montotal"].ToString();
                    objviaj.servcab_km = rdr["servcab_km"].ToString();
                    objviaj.servcab_obs = rdr["servcab_obs"].ToString();
                    objviaj.servcab_fecreg = rdr["servcab_fecreg"].ToString();
                    Lstviaj.Add(objviaj);
                }
                conex.Close();
                return Lstviaj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<VMServicios_Ciudad>> rptViajexciudad(DateTime fecini, DateTime fecfin)
        {
            try
            {
                List<VMServicios_Ciudad> Lstviaj = new List<VMServicios_Ciudad>();
                SqlCommand cmd = new SqlCommand("[DBO].[SP_REPORTE_VIAJE_Q02]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FECINI", fecini);
                cmd.Parameters.AddWithValue("@FECFIN", fecfin);
                conex.Open();
                SqlDataReader rdr = await cmd.ExecuteReaderAsync();
                while (rdr.Read())
                {
                    VMServicios_Ciudad objviaj = new VMServicios_Ciudad();
                    objviaj.ubig_desc = rdr["ubig_desc"].ToString();
                    objviaj.vehi_placa = rdr["vehi_placa"].ToString();
                    objviaj.chofer_nombre = rdr["chofer_nombre"].ToString();
                    objviaj.chofer_apellido = rdr["chofer_apellido"].ToString();
                    objviaj.servcab_nro = rdr["servcab_nro"].ToString();
                    objviaj.servcab_canttotal = rdr["servcab_canttotal"].ToString();
                    objviaj.servcab_montotal = rdr["servcab_montotal"].ToString();
                    objviaj.servcab_desc = rdr["servcab_desc"].ToString();
                    objviaj.servcab_fec = rdr["servcab_fec"].ToString();
                    objviaj.servcab_km = rdr["servcab_km"].ToString();
                    objviaj.servcab_obs = rdr["servcab_obs"].ToString();
                    objviaj.servcab_fecreg = rdr["servcab_fecreg"].ToString();
                    Lstviaj.Add(objviaj);
                }
                conex.Close();
                return Lstviaj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
