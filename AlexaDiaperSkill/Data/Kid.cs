//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlexaDiaperSkill.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kid
    {
        public Kid()
        {
            this.Diapers = new HashSet<Diaper>();
        }
    
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Diaper> Diapers { get; set; }
        public virtual User User { get; set; }
    }
}
