//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLCommunication
    {
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string topic { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
