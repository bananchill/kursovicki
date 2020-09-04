using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kusach
{
    class DbController
    {
        public static user activeUser;
        public typeoborud obor;
        public static tochnokursachEntities db { get; set; }
        static DbController()
        {
            db = new tochnokursachEntities();
        }
        // -------------------------------------
        public void Addzakaz(zakaz zakaz)
        {
            db.zakaz.Add(zakaz);
            db.SaveChanges();
        }
        internal static List<izdelia> Loadizd()
        {
            db.izdelia.Load();
            List<izdelia> users = db.izdelia.Local.ToList();
            return users.Where(u => u.idizdelia == u.idizdelia).ToList();

        }
        public void Adduser(user user)
        {
            activeUser = user;
            db.user.Add(user);
            db.SaveChanges();
        }
        public static List<string> user()
        {
            List<string> list = new List<string>();
            var query = db.user.ToList();
            foreach (var roles in query)
            {
                list.Add(roles.iduser.ToString());
            }
            return list;
        }
        public static List<string> izd()
        {
            List<string> list = new List<string>();
            var query = db.izdelia.ToList();
            foreach (var roles in query)
            {
                list.Add(roles.name.ToString());
            }
            return list;
        }
        public static List<string> User()
        {
            List<string> list = new List<string>();
            var query = db.user.ToList();
            foreach (var roles in query)
            {
                list.Add(roles.role.ToString());
            }
            return list;
        }

        public static user Activeus(string login, string password)
        {

            db.user.Load();
            List<user> users = db.user.Local.ToList();
            foreach (var user in users)
            {
                if (user.login == login && user.password == password)
                {
                    return user;
                }
            }
            return null;

        }
        public string online(string login, string password)
        {
            var query = from user in db.user
                        where activeUser.login == user.login && activeUser.password == user.password
                        select user.role;
            foreach (string usser in query)
            {
                switch (usser)
                {
                    case "Заказчик":
                        return "Заказчик";
                    case "Менеджер":
                        return "Менеджер";
                    case "Мастер":
                        return "Мастер";
                }
            }
            return "Exception";
        }
        public string online2(string login, string password)
        {
            var query = from user in db.user
                        where activeUser.login == login && activeUser.password == password
                        select user.role;
            foreach (string usser in query)
            {
                switch (usser)
                {
                    case "Директор":
                        return "Директор";
                    default:
                        return "0";
                }
            }
            return "Exception";
        }
        //--------------------------------
        public string autorization(string login, string password)
        {
            var query = from user in db.user
                        where user.login == login && user.password == password
                        select user.role;
            foreach (string usser in query)
            {
                switch (usser)
                {
                    case "Заказчик":
                        return "Заказчик";
                    case "Менеджер":
                        return "Менеджер";
                    case "Мастер":
                        return "Мастер";
                    case "Директор":
                        return "Директор";
                    default:
                        return "0";
                }
            }
            return "Exception";
        }
       
        public static zakaz kaka(int id)
        {
            var query = from zakaz in db.zakaz
                        where zakaz.idzakaz == id && zakaz.name == "Подтверждение" || zakaz.name == "подтверждение"
                        select zakaz;
            foreach (var roles in query)
            {
                return roles;
            }
            return null;
        }
        public static material kiki(string articul,string name , string izmer, string dlina , string count,string typemat )
        {
            var query = from material in db.material
                        select material;
            foreach (var roles in query)
            {
                return roles;
            }
            return null;
        }
        public static furnitura klkl(string articul,string name , string izmer, string dlina ,string count,string typemat )
        {
            var query = from furnitura in db.furnitura
                        select furnitura;
            foreach (var roles in query)
            {
                return roles;
            }
            return null;
        }

        public static zakaz toto(int id)
        {
            var query = from zakaz in db.zakaz
                        where zakaz.idzakaz == id && zakaz.name == "Готов" || zakaz.name == "готов"
                        select zakaz;
            foreach (var roles in query)
            {
                return roles;
            }
            return null;
        }
        public static zakaz koko(int id)
        {
            var query = from zakaz in db.zakaz
                        where zakaz.idzakaz == id && zakaz.name == "Контроль" || zakaz.name == "контроль"
                        select zakaz;
            foreach (var roles in query)
            {
                return roles;
            }
            return null;
        }
       

        //------------------------------------------

        public static List<zakaz> ZAkazus(user users, izdelia izdelias)
        {
            List<zakaz> list = new List<zakaz>();
            var query = from zakaz in db.zakaz
                        join izdelia in db.izdelia on zakaz.izdelia_idizdelia equals izdelia.idizdelia
                        join user in db.user on zakaz.user_iduser equals user.iduser
                        where users.iduser == zakaz.user_iduser
                        select zakaz;
            foreach (var roles in query)
            {
                list.Add(new zakaz(roles.idzakaz, roles.datestart, roles.name, roles.cost, roles.datefinish));
            }
            return list;
        }

        public static List<oborudovanie> oborud()
        {
            List<oborudovanie> list = new List<oborudovanie>();
            var query = from oborudovanie in db.oborudovanie
                        join typeoborud in db.typeoborud on oborudovanie.typeoborud_idtypeoborud equals typeoborud.idtypeoborud
                        select oborudovanie;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;

        }
        public static List<zakaz> Allzakaz()
        {
            List<zakaz> list = new List<zakaz>();
            var query = db.zakaz.ToList();
            return query;
        }

        public static List<zakaz> Newzakaz(user users)
        {
            db.zakaz.Load();
            List<zakaz> zakazs = new List<zakaz>();
            return zakazs.Where(o => o.name == "Новый").ToList();
        }
        public static List<zakaz> Podtzakaz(user users)
        {
            List<zakaz> list = new List<zakaz>();
            var query = from zakaz in db.zakaz
                        where zakaz.name == "Подтверждение" || zakaz.name == "подтверждение"
                        select zakaz;
            foreach (var roles in query)
            {
                list.Add(new zakaz(roles.idzakaz, roles.datestart, roles.name, roles.cost, roles.datefinish));
            }
            return list;
        }
        public static List<zakaz> Proizv(user users)
        {
            //List<furnitura> listfur = new List<furnitura>();
            //List<specifsbor_ed> listspecif = new List<specifsbor_ed>();
            //List<specifikfurniture> listapecfurn = new List<specifikfurniture>();
            //List<izdelia> listzakaz = new List<izdelia>();
            //var query = from zakaz in db.zakaz
            //            join izdelia in db.izdelia on zakaz.izdelia_idizdelia equals izdelia.idizdelia
            //            join specifsbor_ed in db.specifsbor_ed on izdelia.specifsbor_ed 
            //            join specifikfurniture in db.specifikfurniture on izdelia.specifikfurniture equals specifikfurniture.idspecifikfurniture                      
            //            where zakaz.name == "Подтверждение" || zakaz.name == "подтверждение"
            //            select zakaz;
            //foreach (var roles in query)
            //{
            //    list.Add(new zakaz(roles.idzakaz, roles.datestart, roles.name, roles.cost, roles.datefinish));
            //}
            //return list;
            return null;
        }

        public static List<zakaz> Zakupka(user users)
        {
            List<zakaz> list = new List<zakaz>();
            var query = from zakaz in db.zakaz
                        where zakaz.name == "Закупка" || zakaz.name == "закупка" || zakaz.name == "Составление спецификации" || zakaz.name == "составление спецификации"
                        select zakaz;
            foreach (var roles in query)
            {
                list.Add(new zakaz(roles.idzakaz, roles.datestart, roles.name, roles.cost, roles.datefinish));
            }
            return list;
        }
        public static List<material> Zakupkamater()
        {
            db.material.Load();
            List<material> material = db.material.Local.ToList();
            return material.Where(o => o.idmaterial == o.idmaterial).ToList();
        }
        public static List<furnitura> Zakupkafurn()
        {
            db.furnitura.Load();
            List<furnitura> furnitura = db.furnitura.Local.ToList();
            return furnitura.Where(o => o.idfurnitura == o.idfurnitura).ToList();
        }
        public static List<zakaz> POdtmaster(user users)
        {
            List<zakaz> list = new List<zakaz>();
            var query = from zakaz in db.zakaz
                        where zakaz.name == "Производство" || zakaz.name == "Контроль" || zakaz.name == "производство" || zakaz.name == "контроль"
                        select zakaz;
            foreach (var roles in query)
            {
                list.Add(new zakaz(roles.idzakaz, roles.datestart, roles.name, roles.cost, roles.datefinish));
            }
            return list;
        }
        public static List<zakaz> Oplachen(user users)
        {
            List<zakaz> list = new List<zakaz>();
            var query = from zakaz in db.zakaz
                        where zakaz.name == "Готов" || zakaz.name == "готов"
                        select zakaz;
            foreach (var roles in query)
            {
                list.Add(new zakaz(roles.idzakaz, roles.datestart, roles.name, roles.cost, roles.datefinish));
            }
            return list;
        }




        //---------------------------------------------------

        public static void save()
        {
            db.SaveChanges();
        }

    }
}