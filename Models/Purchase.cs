//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tatakae.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        public int Id { get; set; }
        public Nullable<int> CId { get; set; }
        public Nullable<int> UId { get; set; }
        public string OrderId { get; set; }
        public string PaymentId { get; set; }
        public string CheckSum { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Status { get; set; }
    }
}
