using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    public partial class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrder { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }

        [Index]
        public int? IdProduct { get; set; }
        public virtual Product Product { get; set; }

        [Index]
        public int? IdUser { get; set; }
        public virtual User User { get; set; }

        [Index]
        public int? IdManager { get; set; }
        public virtual User Manager { get; set; }

        public int Price { get; set; }
        public DateTime? EndDate { get; set; }
        public string status { get; set; }
    }
}
