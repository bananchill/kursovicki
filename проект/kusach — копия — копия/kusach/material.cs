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
    
    public partial class material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public material()
        {
            this.specificmater = new HashSet<specificmater>();
        }
    
        public int idmaterial { get; set; }
        public string articul { get; set; }
        public string name { get; set; }
        public string izmered { get; set; }
        public string dlina { get; set; }
        public string count { get; set; }
        public string typemater { get; set; }
        public string zakupcost { get; set; }
        public string GOST { get; set; }
        public string izobr { get; set; }
        public string haracteristic { get; set; }
        public int postavchik_idpostavchik { get; set; }
    
        public virtual postavchik postavchik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<specificmater> specificmater { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
