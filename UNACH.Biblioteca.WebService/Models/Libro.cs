//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNACH.Biblioteca.WebService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Libro
    {
        public System.Guid Id { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public Nullable<int> AñoPublicacion { get; set; }
        public string Editorial { get; set; }
    }
}
