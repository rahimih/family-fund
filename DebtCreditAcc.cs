//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace familial_bank
{
    using System;
    using System.Collections.Generic;
    
    public partial class DebtCreditAcc
    {
        public int Code { get; set; }
        public Nullable<byte> AccCode { get; set; }
        public string DateP { get; set; }
        public string TimeP { get; set; }
        public Nullable<double> Variz_Cash { get; set; }
        public Nullable<double> Bardasht_Cash { get; set; }
        public Nullable<int> FishNumber { get; set; }
        public string Descriptions { get; set; }
        public Nullable<byte> Kind { get; set; }
        public Nullable<int> UserCode { get; set; }
        public string IpAdress { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual BankAcc BankAcc { get; set; }
        public virtual DebtCreditKind DebtCreditKind { get; set; }
    }
}
