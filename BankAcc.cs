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
    
    public partial class BankAcc
    {
        public BankAcc()
        {
            this.RequestChecks = new HashSet<RequestCheck>();
            this.SignaturesAccs = new HashSet<SignaturesAcc>();
            this.DebtCreditAccs = new HashSet<DebtCreditAcc>();
        }
    
        public byte Code { get; set; }
        public string Descriptions { get; set; }
        public Nullable<byte> Kind { get; set; }
        public string Bnak { get; set; }
        public string BranchName { get; set; }
        public Nullable<int> BranchCode { get; set; }
        public string AccNumber { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> UserCode { get; set; }
        public string IpAdress { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual ICollection<RequestCheck> RequestChecks { get; set; }
        public virtual ICollection<SignaturesAcc> SignaturesAccs { get; set; }
        public virtual ICollection<DebtCreditAcc> DebtCreditAccs { get; set; }
    }
}
