//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemNekretnine.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class VrsteProdaje
    {
        public VrsteProdaje()
        {
            this.Nekretnine = new HashSet<Nekretnine>();
        }
    
        public int VrstaID { get; set; }
        public string NazivVrste { get; set; }
    
        public virtual ICollection<Nekretnine> Nekretnine { get; set; }
    }
}
