using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    public partial class OperationSpec
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOpSpec { get; set; }

        [Index]
        public int? IdProduct { get; set; }
        public virtual Product Product { get; set; }

        [Index]
        public int? IdEquipType { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }

        public string Operation { get; set; }
        public int Time { get; set; }
    }
}
