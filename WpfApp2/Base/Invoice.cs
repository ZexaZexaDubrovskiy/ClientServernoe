//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int Invoice_ID { get; set; }
        public int Contract_ID { get; set; }
        public string Settled { get; set; }
        public string Sum { get; set; }
        public double Sum_inclVAT { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Contract Contract { get; set; }
    }
}
