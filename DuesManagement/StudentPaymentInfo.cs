//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuesManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentPaymentInfo
    {
        public long PaymentID { get; set; }
        public Nullable<long> StudentID { get; set; }
        public string Ocak { get; set; }
        public string Şubat { get; set; }
        public string Mart { get; set; }
        public string Nisan { get; set; }
        public string Mayıs { get; set; }
        public string Haziran { get; set; }
        public string Temmuz { get; set; }
        public string Ağustos { get; set; }
        public string Eylül { get; set; }
        public string Ekim { get; set; }
        public string Kasım { get; set; }
        public string Aralık { get; set; }
    
        public virtual StudentInfo StudentInfo { get; set; }
    }
}
