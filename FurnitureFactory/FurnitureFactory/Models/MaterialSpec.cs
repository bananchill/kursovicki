using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    public partial class MaterialSpec
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMaterialSpec { get; set; }

        [Index]
        public int? IdProduct { get; set; }
        public virtual Product Product { get; set; }

        [Index]
        public int? IdMaterial { get; set; }
        public virtual Material Material { get; set; }

        public int Count { get; set; }
    }
}
