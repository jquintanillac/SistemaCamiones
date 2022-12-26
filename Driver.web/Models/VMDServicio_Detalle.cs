namespace Driver.web.Models
{
    public class VMDServicio_Detalle
    {
        public int id_servdet { get; set; }
        public int id_servcab { get; set; }
        public int id_transp { get; set; }
        public string transp_desc { get; set; }
        public int id_chofer { get; set; }
        public string chof_nomcomp { get; set; }
        public int id_vehi { get; set; }
        public string vehi_placa { get; set; }
        public double servdet_cantdet { get; set; }
        public double servdet_preunit { get; set; }
    }
}
