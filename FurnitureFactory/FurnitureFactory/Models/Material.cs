using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    public partial class Material
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMaterial { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Length { get; set; }
        public int Count { get; set; }


        [Index]
        public int? IdProvider { get; set; }
        public virtual Provider Provider { get; set; }


        public int Price { get; set; }
        public string GOST { get; set; }
        public string characteristic { get; set; }
    }
}
