//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFDeviceManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Document
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public int NodeID { get; set; }
    
        public virtual Node Node { get; set; }
    }
}