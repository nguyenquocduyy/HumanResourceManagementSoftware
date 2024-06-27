//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataObject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Accounts = new HashSet<Account>();
            this.BoardSalaryDes = new HashSet<BoardSalaryDe>();
            this.Disciplines = new HashSet<Discipline>();
            this.Insurances = new HashSet<Insurance>();
            this.PayRolls = new HashSet<PayRoll>();
            this.Rewards = new HashSet<Reward>();
            this.Salaries = new HashSet<Salary>();
            this.Salaries1 = new HashSet<Salary>();
            this.StaffJoinAllowances = new HashSet<StaffJoinAllowance>();
            this.Contracts = new HashSet<Contract>();
        }
    
        public int id { get; set; }
        public string nameStaff { get; set; }
        public Nullable<bool> gender { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string phone { get; set; }
        public string identify { get; set; }
        public string address { get; set; }
        public byte[] image { get; set; }
        public Nullable<int> idRoom { get; set; }
        public Nullable<int> idPosition { get; set; }
        public Nullable<int> idLever { get; set; }
        public Nullable<int> idNation { get; set; }
        public Nullable<bool> maritalStatus { get; set; }
        public Nullable<bool> status { get; set; }
        public string bankNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardSalaryDe> BoardSalaryDes { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Discipline> Disciplines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Insurance> Insurances { get; set; }
        public virtual Lever Lever { get; set; }
        public virtual Nation Nation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayRoll> PayRolls { get; set; }
        public virtual Position Position { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reward> Rewards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salary> Salaries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salary> Salaries1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffJoinAllowance> StaffJoinAllowances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
