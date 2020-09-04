using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    class FFInitializer : CreateDatabaseIfNotExists<FFContext>
    {
        protected override void Seed(FFContext db)
        {
            User test = new User { Login = "loginDExzi2018", Password = "{+1T1M", FIO = "Антонин Яковович", Role = "Директор" };

            User test2 = new User { Login = "loginDEsar2018", Password = "2M2IQH", FIO = "Ефим Ильяович", Role = "Менеджер" };

            User test3 = new User { Login = "loginDEuxd2018", Password = "*PI3KN", FIO = "Маргарита Валерьяновна", Role = "Заместитель директора" };

            User test4 = new User { Login = "loginDEepk2018", Password = "VZ&Ak7", FIO = "Гордей Серапионович", Role = "Заказчик" };

            User test5 = new User { Login = "loginDElkc2018", Password = "BOvRGk", FIO = "Онисим Ярославович", Role = "Мастер" };
            db.User.Add(test);
            db.User.Add(test2);
            db.User.Add(test3);
            db.User.Add(test4);
            db.User.Add(test5);

            Provider provider1 = new Provider {Name = "ООО Транс-Милос", Address = "Улица Пушкина, дом Колотушкина", Date = new DateTime(2018, 5, 15)};

            db.Provider.Add(provider1);

            Furniture furniture1 = new Furniture { Name = "Дюбель 6 х 30 серый, пластик", Unit = "шт", Count = 2302, Provider = provider1, Type = "Дюбель", Price = 1.13088f };

            db.Furniture.Add(furniture1);

            Material material1 = new Material { Name = "Брус обрезной, 100х150х6000 мм, 1 сорт", Unit = "шт", Length = 6, Provider = provider1, Price = 800 };

            db.Material.Add(material1);

            EquipmentType equipmentType1 = new EquipmentType { };

            Product product1 = new Product { Name = "Стул", Size = "40x40x60" };

            db.Product.Add(product1);

            Order order1 = new Order { Date = new DateTime(2018, 5, 15), Name = "Стулья", Product = product1, User = test4, Manager = test2, Price = 800000, EndDate = new DateTime(2020, 5, 15), status = "Готово" };
            db.Order.Add(order1);
        }
    }
}
