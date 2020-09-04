using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    public partial class Equipment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEquip { get; set; }

        [Index]
        public int? IdEquipType { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }

        public string characteristic { get; set; }
    }
}
