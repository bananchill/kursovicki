//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kusach
{
    using System;
    using System.Collections.Generic;
    
    public partial class zakaz
    {
        public zakaz(int idzakaz, DateTime datestart, string name, string cost, DateTime? datefinish)
        {
            this.idzakaz = idzakaz;
            this.datestart = datestart;
            this.name = name;
            this.cost = cost;
            this.datefinish = datefinish;
        }
        public zakaz() { }
        public int idzakaz { get; set; }
        public System.DateTime datestart { get; set; }
        public string name { get; set; }
        public string cost { get; set; }
        public Nullable<System.DateTime> datefinish { get; set; }
        public string shemi { get; set; }
        public int izdelia_idizdelia { get; set; }
        public int user_iduser { get; set; }
    
        public virtual izdelia izdelia { get; set; }
        public virtual user user { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
