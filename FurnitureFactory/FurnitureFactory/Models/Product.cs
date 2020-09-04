using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    public partial class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }

    }
}
