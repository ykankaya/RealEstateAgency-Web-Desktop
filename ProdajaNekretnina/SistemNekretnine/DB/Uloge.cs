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
    
    public partial class Uloge
    {
        public Uloge()
        {
            this.KorisniciUloge = new HashSet<KorisniciUloge>();
        }
    
        public int UlogaID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    
        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
