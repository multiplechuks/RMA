//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photo
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int ResultId { get; set; }
        public string Reporter { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Result Result { get; set; }
    }
}