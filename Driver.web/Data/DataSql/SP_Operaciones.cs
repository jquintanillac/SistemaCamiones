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
    public class SP_Operaciones
    {
        public SqlConnection conex;
        public SP_Operaciones()
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
        /// Generar detalle de vehiculo procesos
        /// </summary>
        /// <param name="id_provehi"></param>
        public void mGenerarprocvehidet(int id_provehi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[DBO].[SP_PROCESO_VEHICULO_DET_I01]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PROVEHI", id_provehi);             
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Generar detalle de vehiculo procesos
        /// </summary>
        /// <param name="id_provehi"></param>
        public void mGenerarinventario(int id_product)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[DBO].[SP_INVENTARIO_PRODUCTO_I01]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PRODUCT", id_product);
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Eliminar detalle de vehiculo procesos
        /// </summary>
        /// <param name="id_provehi"></param>
        public void mEliminarprocvehidet(int id_provehi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[DBO].[SP_PROCESO_VEHICULO_DET_D01]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PROVEHI", id_provehi);
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Eliminar detalle de vehiculo procesos
        /// </summary>
        /// <param name="id_provehi"></param>
        public void mEliminardocudetalle(int id_doccab)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[DBO].[SP_PROCESO_DOCUMENTO_DET_D01]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DOCCAB", id_doccab);
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
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
        public List<VMDocumento_Cabecera> mListarDocumentoCabecera(string id, DateTime fecha)
        {
            try
            {
                List<VMDocumento_Cabecera> Lstdocucab = new List<VMDocumento_Cabecera>();
                SqlCommand cmd = new SqlCommand("[DBO].[SP_PROCESO_DOCUMENTO_CAB_Q01]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TIPDOC", id);
                cmd.Parameters.AddWithValue("@FECHA", fecha);
                conex.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    VMDocumento_Cabecera objdoc = new VMDocumento_Cabecera();
                    objdoc.id_doccab = Convert.ToInt32(rdr["id_doccab"]);
                    objdoc.id_chofer = Convert.ToInt32(rdr["id_chofer"]);
                    objdoc.chof_nomcomp = rdr["chof_nomcomp"].ToString();
                    objdoc.doccab_cod = rdr["doccab_cod"].ToString();
                    objdoc.doccab_desc = rdr["doccab_desc"].ToString();
                    objdoc.doccab_est = rdr["doccab_est"].ToString();
                    Lstdocucab.Add(objdoc);
                }
                conex.Close();
                return Lstdocucab;
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
        public List<VMDocumento_Detalle> mListarDocumentodetalle(int id_doccab, DateTime fecha)
        {
            try
            {
                List<VMDocumento_Detalle> Lstdocudet = new List<VMDocumento_Detalle>();
                SqlCommand cmd = new SqlCommand("[DBO].[SP_PROCESO_DOCUMENTO_DET_Q01]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DOCCAB", id_doccab);
                cmd.Parameters.AddWithValue("@FECHA", fecha);
                conex.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    VMDocumento_Detalle objdet = new VMDocumento_Detalle();
                    objdet.id_docdet = Convert.ToInt32(rdr["id_docdet"]);
                    objdet.id_doccab = Convert.ToInt32(rdr["id_doccab"]);
                    objdet.id_tipdoc = Convert.ToInt32(rdr["id_tipdoc"]);
                    objdet.tipdoc_desc =  rdr["tipdoc_desc"].ToString();
                    objdet.docdet_fecemi = Convert.ToDateTime(rdr["docdet_fecemi"]);
                    objdet.docdet_venci = Convert.ToDateTime(rdr["docdet_venci"]);
                    objdet.docdet_entemi = rdr["docdet_entemi"].ToString();
                    objdet.docdet_alert = rdr["docdet_alert"].ToString();
                    objdet.docdet_obse = rdr["docdet_obse"].ToString();
                    Lstdocudet.Add(objdet);
                }
                conex.Close();
                return Lstdocudet;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Eliminar detalle de vehiculo procesos
        /// </summary>
        /// <param name="id_provehi"></param>
        public void mUpdateViatcab(int id_viatcab)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[DBO].[SP_VIATICO_CAB_U01]", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_VIATCAB", id_viatcab);
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
