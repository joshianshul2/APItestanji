//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemMaster
    {
        public int PK_ItemId { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string ItemName { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<double> OfferRate { get; set; }
        public string ImageName { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<bool> IsCOD { get; set; }
        public Nullable<bool> IsFreeDel { get; set; }
        public Nullable<bool> ShowFrontTop_3 { get; set; }
        public Nullable<bool> ShowFrontMid_3 { get; set; }
        public Nullable<bool> ShowFrontBottom_3 { get; set; }
        public Nullable<bool> ShowFrontSlider_10 { get; set; }
        public Nullable<bool> ShowLeftFront_5 { get; set; }
        public Nullable<bool> ShowFrontSingle_1 { get; set; }
        public Nullable<bool> ShowTop3 { get; set; }
        public Nullable<bool> ShowBottom9 { get; set; }
        public Nullable<bool> ShowSlider9 { get; set; }
        public Nullable<bool> ShowLeft5 { get; set; }
        public Nullable<int> Position { get; set; }
        public Nullable<int> FrontPosition { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}