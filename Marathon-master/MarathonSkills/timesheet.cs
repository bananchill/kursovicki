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
    
    public partial class timesheet
    {
        public int TimesheetId { get; set; }
        public int StaffId { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public Nullable<decimal> PayAmount { get; set; }
    
        public virtual staff staff { get; set; }
    }
}
