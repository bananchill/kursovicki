using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    class FFContext : DbContext
    {
        public FFContext() : base("name=FurnitureFactoryDB")
        {

        }

        static FFContext()
        {
            Database.SetInitializer<FFContext>(new FFInitializer());
        }

        public virtual DbSet<AssemblyUnitSpec> AssemblyUnitSpec { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentType> EquipmentType { get; set; }
        public virtual DbSet<Furniture> Furniture { get; set; }
        public virtual DbSet<FurnitureSpec> FurnitureSpec { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialSpec> MaterialSpec { get; set; }
        public virtual DbSet<OperationSpec> OperationSpec { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<User> User { get; set; }

    }
}
