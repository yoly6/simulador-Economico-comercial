using System;


namespace Etafashion
{
    class Productos
    {
        //Propiedades
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public string Cantidad { get; set; }
        public string Talla { get; set; }
        public Persona Comprador { get; set; }
        public Persona Proveedor { get; set; }

        public string Factura ( ){
            return $"su pedido seria el siguiente {NombreProducto} Talla-{Talla} Precio-{Precio} Cantidad-{Cantidad}";
        }

        public string Pedidos ( ){
            return $"su pedido {NombreProducto} se a realizado con Exito!!!";
        }
    }
}