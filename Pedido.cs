namespace Etafashion
{
    class Pedido
    {
        //Propiedades
        public int Id { get; set; }
        public string NombrePedido{ get; set; }
        public string Cantidad{ get; set; }
        public string Color { get; set; }
        public int Costo { get; set; }
        //Instancias

       
    
        public string Pagar()
        {
            return $"El precio a pagar por su pedido es de {Costo}";
        }
     
    }
    
}