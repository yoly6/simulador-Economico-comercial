namespace Etafashion
{
    class Proveedor
    {
        //Propiedades
        public int Id { get; set; }
        public string NombreProveedor { get; set; }
        public string RucProveedor { get; set; }
        public string CorreoProveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        public int Costo { get; set; }
        
        //Metodos

        public string Factura1 ( ){
            return $"Empresa: {NombreProveedor} ";
        }

    }
}
