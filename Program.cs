using System;

namespace Etafashion
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Bienvenido a la aplicacion de Etafashion en breves se conecta un acesor que le pueda ayudar con su pedido ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey(); 

             //Instancias
            Persona persona = new Persona
            {
                Id = new Random().Next(),
                NombreApellido = "Juan Ramires",
                Cedula = "1919191919",
                Edad = 28,
                Celular = " 0909090909"
            };
             Console.WriteLine(persona.Presentarse());
               Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey();

             Persona cliente = new Persona
            {
                Id = new Random().Next(),
                NombreApellido = "Marta Lopez",
                Cedula = "1918181818",
                Edad = 57,
                Celular = " 0908080808"
            };
           Console.WriteLine(cliente.PresentarseCliente());
          //  Console.WriteLine(acesor.Entrega());

            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey();

            Productos zapatos = new Productos
            {
                Id = new Random().Next(),
                NombreProducto = "Zapatos Tacos",
                Categoria = "Calzado",
                Precio = 38,
                Talla = "35",
                Cantidad = "2"
            };

            Productos vestido = new Productos
            {
                Id = new Random().Next(),
                NombreProducto = "Vestido color negro de Bellase",
                Categoria = "Ropa Catalogo",
                Talla = "Xl",
                Precio = 35,
                Cantidad = "1"
            };
            Console.WriteLine(zapatos.Factura());
            Console.WriteLine(vestido.Factura());
            Console.WriteLine(zapatos.Pedidos());
            Console.WriteLine(vestido.Pedidos());
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey();

             Proveedor proveedor1 = new Proveedor
            {
                Id = new Random().Next(),
                NombreProveedor = "ConfeccionesAlex",
                RucProveedor = "1315151515001",
                CorreoProveedor = "confeccionesAlex@gmail.com",
                DireccionProveedor = "10 de Agosto",
                TelefonoProveedor = "200000"
            };
            
              
             
             Pedido pedido1 = new Pedido
             {
                 Id = new Random().Next(),
                 NombrePedido = "Vestidos",
                 Cantidad = "500",
                 Color = "Primaver,Oscuros",
                 Costo = 1200
             };
              Console.WriteLine(proveedor1.Factura1());
              Console.WriteLine(pedido1.Pagar());
               Console.WriteLine("------------------------------------------------------------------------");


             Proveedor proveedor2 = new Proveedor
            {
                Id = new Random().Next(),
                NombreProveedor = "LaBota",
                RucProveedor = "1610101010",
                CorreoProveedor = "labota@gmail.com",
                DireccionProveedor = "Marianas N45-5",
                TelefonoProveedor = "0265656",
                
            };
              Pedido pedido2 = new Pedido
             {
                 Id = new Random().Next(),
                 NombrePedido = "Pantalones",
                 Cantidad = "500",
                 Color = "Primaver,Oscuros",
                 Costo = 1800
             };
                Console.WriteLine(proveedor2.Factura1());
                 Console.WriteLine(pedido2.Pagar());
                  Console.WriteLine("------------------------------------------------------------------------");

             Proveedor proveedor3 = new Proveedor
            {
                Id = new Random().Next(),
                NombreProveedor = "La del Textil",
                RucProveedor = "1916161616",
                CorreoProveedor = "lacasadeltextil@gmail.com",
                DireccionProveedor = "La comuna N25-45",
                TelefonoProveedor = "0235698",
                
            };
            Pedido pedido3 = new Pedido
             {
                 Id = new Random().Next(),
                 NombrePedido = "Camisetas",
                 Cantidad = "700",
                 Color = "Primaver,Oscuros",
                 Costo = 2000
             };
                 Console.WriteLine(proveedor3.Factura1());
                 
              Console.WriteLine(pedido3.Pagar());
               Console.WriteLine("------------------------------------------------------------------------");
              Console.WriteLine("Gracias Pro su Compra!!!");
    }
}
}