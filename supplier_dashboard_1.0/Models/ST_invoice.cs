//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace supplier_dashboard_1._0.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ST_invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ST_invoice()
        {
            this.ST_items = new HashSet<ST_items>();
        }
    
        public int ST_Invoice_ID { get; set; }
        public Nullable<int> supplier_userID { get; set; }
        public Nullable<int> PO_code { get; set; }
        public Nullable<int> total_special_excise_duty { get; set; }
        public Nullable<int> total_sales_tax { get; set; }
        public Nullable<int> quotation_code { get; set; }
        public Nullable<int> total_value_of_goods { get; set; }
        public Nullable<System.DateTime> invoice_date { get; set; }
    
        public virtual item item { get; set; }
        public virtual PO PO { get; set; }
        public virtual quotation quotation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ST_items> ST_items { get; set; }
    }
}
