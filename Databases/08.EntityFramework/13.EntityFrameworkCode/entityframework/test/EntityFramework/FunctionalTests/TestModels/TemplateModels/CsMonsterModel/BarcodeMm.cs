//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunctionalTests.ProductivityApi.TemplateModels.CsMonsterModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class BarcodeMm
    {
        public BarcodeMm()
        {
            this.BadScans = new HashSet<IncorrectScanMm>();
        }
    
        public byte[] Code { get; set; }
        public int ProductId { get; set; }
        public string Text { get; set; }
    
        public virtual ProductMm Product { get; set; }
        public virtual ICollection<IncorrectScanMm> BadScans { get; set; }
        public virtual BarcodeDetailMm Detail { get; set; }
    }
}
