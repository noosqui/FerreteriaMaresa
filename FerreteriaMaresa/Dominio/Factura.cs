namespace Dominio
{
    public class Factura
    {
        public int Id { get; set; }
        public string nomProd { get; set; }
        public double price { get; set; }
        public int Cantidad { get; set; }
        // public double total { get; set; }
        public string CantxUnidad { get; set; }
    }
}
