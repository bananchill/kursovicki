//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarathonSkills
{
    using System;
    using System.Collections.Generic;
    
    public partial class sponsorship
    {
        public int SponsorshipId { get; set; }
        public string SponsorName { get; set; }
        public int RegistrationId { get; set; }
        public decimal Amount { get; set; }
    
        public virtual registration registration { get; set; }
    }
}
