using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    public partial class Furniture
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFurniture { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Count { get; set; }

        [Index]
        public int? IdProvider { get; set; }
        public virtual Provider Provider { get; set; }

        public string Type { get; set; }
        public float Price { get; set; }
        public int Weight { get; set; }
    }
}
