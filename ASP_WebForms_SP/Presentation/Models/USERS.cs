//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERS
    {
        public int ID_U { get; set; }
        public string C_USER { get; set; }
        public string PASS { get; set; }
        public int ID_R { get; set; }
    
        public virtual ROLES ROLES { get; set; }
    }
}