using System;

namespace Etafashion
{
    class Persona
    {
        //Propiedades
        public int Id { get; set; }
        public string NombreApellido { get; set; }
        public string Cedula { get; set; }
        public int Edad { get; set; }
        public string Celular { get; set; }
        //Instancias

        public string Presentarse ( ){
            return $"Hola soy su acesor personal mi nombre es {NombreApellido} tengo {Edad}años y mi celular es {Celular} ,es un gusto atenderle cual es su nombre";
        }
       public string PresentarseCliente (){
            return $"Buenas tardes mi nombre es  {NombreApellido} mi numero de cedula es {Cedula} y mi celular es {Celular} necesito comprar unos zapatos talla 35 y un vestido talla xl color negro de bellase";
        }
     
    }
    
}