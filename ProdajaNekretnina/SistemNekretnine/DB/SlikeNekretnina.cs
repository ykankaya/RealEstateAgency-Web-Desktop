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
    
    public partial class SlikeNekretnina
    {
        public int SlikaID { get; set; }
        public byte[] SlikaNekretnine { get; set; }
        public Nullable<int> NekretninaID { get; set; }
    
        public virtual Nekretnine Nekretnine { get; set; }
    }
}