//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Blog
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public int UserID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int RatingPoint { get; set; }
        public int NumOfRating { get; set; }
        public int CategoryID { get; set; }
    
        public virtual Tbl_Category Tbl_Category { get; set; }
        public virtual Tbl_User Tbl_User { get; set; }
    }
}