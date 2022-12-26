namespace Driver.web.Models
{
    public class VMDInventario
    {
        public int id_invet { get; set; }
        public int id_product { get; set; }
        public string product_descr { get; set; }
        public int invet_cant { get; set; }
        public double invet_prepro { get; set; }
        public double invet_pretotal { get; set; }
        public bool invet_act { get; set; }
    }
}
