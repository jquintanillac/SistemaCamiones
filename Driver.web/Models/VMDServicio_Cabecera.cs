using System;

namespace Driver.web.Models
{
    public class VMDServicio_Cabecera
    {
        public int id_servcab { get; set; }
        public int id_cliente { get; set; }
        public string clie_razsocial { get; set; }
        public int id_carga { get; set; }
        public string carg_desc { get; set; }
        public int id_ubigeo_partida { get; set; }
        public string ubig_origen { get; set; }
        public int id_ubigeo_llegada { get; set; }
        public int id_tipserv { get; set; }
        public string tipserv_descr { get; set; }
        public string ubig_llegada { get; set; }
        public string servcab_nro { get; set; }
        public string servcab_guia { get; set; }
        public string servcab_desc { get; set; }
        public DateTime servcab_fec { get; set; }
        public double servcab_canttotal { get; set; }
        public double servcab_montotal { get; set; }
        public double servcab_km { get; set; }
        public string servcab_obs { get; set; }

    }
}
