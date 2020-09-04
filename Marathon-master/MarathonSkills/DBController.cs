using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;

namespace MarathonSkills
{
    class DBController
    {
        public user activeUser;
        public runner activeRunner;
        public static MarathonSkillsEntities db { get; set; }
        static DBController()
        {
            db = new MarathonSkillsEntities();
        }

        public void AddRunner(user user, runner runner)
        {
            activeUser = user;
            activeRunner = runner;
            db.user.Add(user);
            db.runner.Add(runner);
            db.SaveChanges();
        }

        public void AddCharity(charity newCharity)
        {
            db.charity.Add(newCharity);
            db.SaveChanges();
        }

        public void AddUser(user user)
        {
            db.user.Add(user);
            db.SaveChanges();
        }

        public string autorization(string email, string password)
        {
            var query = from user in db.user
                        where user.Email == email && user.Password == password
                        select user.RoleId;
            foreach (string usser in query)
            {
                switch (usser)
                {
                    case "R":
                        return "R";
                    case "A":
                        return "A";
                    case "C":
                        return "C";
                    default:
                        return "Exception";
                }
            }
            return "Exception";
        }

        public user ActiveUser(string email, string password)
        {
            db.user.Load();
            List<user> users = db.user.Local.ToList();
            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public string list(string id)
        {
            string list = "";
            var query = from racekitoption in db.racekitoption
                        where racekitoption.RaceKitOptionId == id
                        select racekitoption.Cost;
            var query1 = from racekitoption in db.racekitoption
                         where racekitoption.RaceKitOptionId == id
                         select racekitoption.RaceKitOption1;
            foreach (int result in query)
            {
                list += result.ToString();
            }
            list += " $ - ";
            foreach (string result in query1)
            {
                list += result.ToString();
            }
            return list;
        }

        public string getCharityPhoto(string charityName)
        {
            string list = "";
            var query = from charity in db.charity
                        where charity.CharityName == charityName
                        select charity.CharityLogo;
            foreach (string result in query)
            {
                list += result;
            }
            return list;
        }

        public string getCharityDescription(string charityName)
        {
            string list = "";
            var query = from charity in db.charity
                        where charity.CharityName == charityName
                        select charity.CharityDescription;
            foreach (string result in query)
            {
                list += result;
            }
            return list;
        }

        public void AddSponsorship(sponsorship sponsorship)
        {
            db.sponsorship.Add(sponsorship);
            db.SaveChanges();
        }

        public List<string> gender()
        {
            List<string> list = new List<string>();
            var query = db.gender.ToList();
            foreach (var roles in query)
            {
                list.Add(roles.Gender1.ToString());
            }
            return list;
        }

        public List<string> role()
        {
            List<string> list = new List<string>();
            var query = db.role.ToList();
            list.Add("Все");
            foreach (var roles in query)
            {
                list.Add(roles.RoleName.ToString());
            }
            return list;
        }

        public List<string> roles()
        {
            List<string> list = new List<string>();
            var query = db.role.ToList();
            foreach (var roles in query)
            {
                list.Add(roles.RoleName.ToString());
            }
            return list;
        }

        public string roleId(string roleName)
        {
            string list = "";
            var query = from role in db.role
                        where role.RoleName == roleName
                        select role.RoleId;
            foreach (string result in query)
            {
                list += result;
            }
            return list;
        }

        public List<string> runner()
        {
            List<string> list = new List<string>();
            var query = db.runner.ToList();
            foreach (var roles in query)
            {
                list.Add(roles.RunnerId.ToString() + " " + roles.user.LastName.ToString() + " " + roles.user.FirstName.ToString());
            }
            return list;
        }

        public List<string> country()
        {
            List<string> list = new List<string>();
            var query = db.country.ToList();
            foreach (var roles in query)
            {
                list.Add(roles.CountryCode.ToString());
            }
            return list;
        }

        public List<string> LoadCharity()
        {
            List<string> list = new List<string>();
            db.charity.Load();
            var query = db.charity.ToList();
            foreach (var roles in query)
            {
                list.Add(roles.CharityName.ToString());
            }
            return list;
        }

        public int CountRegEventFM()
        {
            db.registrationevent.Load();
            int count = db.registrationevent.Where(ch => ch.EventId == "20_2FM").Count();
            return count;
        }
        public int CountRegEventHM()
        {
            db.registrationevent.Load();
            int count = db.registrationevent.Where(ch => ch.EventId == "20_2HM").Count();
            return count;
        }
        public int CountRegEventFR()
        {
            db.registrationevent.Load();
            int count = db.registrationevent.Where(ch => ch.EventId == "20_2FR").Count();
            return count;
        }

        public int getIdRunner(int id)
        {
            int list = 0;
            var query = from registration in db.registration
                        where registration.RunnerId == id
                        select registration.RegistrationId;
            foreach (int result in query)
            {
                list = result;
            }
            return list;
        }

        public void AddRegistrationEvent(registrationevent registrationEvent)
        {
            db.registrationevent.Add(registrationEvent);
            db.SaveChanges();
        }

        public void AddRegistration(registration registration)
        {
            db.registration.Add(registration);
            db.SaveChanges();
        }

        public List<marathon> LoadMarathon()
        {
            db.marathon.Load();
            var listMarathon = db.marathon;
            return listMarathon.ToList();
        }
        public List<@event> LoadEvent()
        {
            db.@event.Load();
            var listEvent = db.@event;
            return listEvent.ToList();
        }
        public List<eventtype> LoadEventType()
        {
            db.eventtype.Load();
            var listEventType = db.eventtype;
            return listEventType.ToList();
        }
        public List<registrationevent> LoadRegistrationEvent()
        {
            db.registrationevent.Load();
            var listRegistrationEvent = db.registrationevent;
            return listRegistrationEvent.ToList();
        }
        public List<registration> LoadRegistration()
        {
            db.registration.Load();
            var listRegistration = db.registration;
            return listRegistration.ToList();
        }

        public void Edit()
        {
            db.SaveChanges();
        }

        public List<sponsorship> Sonsorship(registration registration)
        {
            db.sponsorship.Load();
            var listSponsorhip = db.sponsorship.Where(sp => sp.RegistrationId == registration.RegistrationId);
            return listSponsorhip.ToList();
        }

        public List<user> UserGrid(user userId)
        {
            List<user> list = new List<user>();
            var query = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where user.RoleId == userId.RoleId
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };
            foreach (var roles in query)
            {
                list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
            }
            return list;
        }

        public List<charity> GetCharity()
        {
            db.charity.Load();
            var listCharity = db.charity;
            return listCharity.ToList();
        }

        public List<user> UserGridSearch(string userId)
        {
            List<user> list = new List<user>();
            var query = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where user.LastName == userId || user.FirstName == userId
                        || user.Email == userId
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };
            foreach (var roles in query)
            {
                list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
            }
            return list;
        }

        public List<user> UserGridSearch(string userId, string sort)
        {
            List<user> list = new List<user>();
            var query = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where user.LastName == userId || user.FirstName == userId
                        || user.Email == userId
                        orderby user.FirstName
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };

            var query1 = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where user.LastName == userId || user.FirstName == userId
                        || user.Email == userId
                        orderby user.LastName
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };
            if (sort.Equals("user.FirstName"))
            {
                foreach (var roles in query)
                {
                    list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
                }
                return list;
            }
            foreach (var roles in query1)
            {
                list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
            }
            return list;
        }

        public List<user> UserGridSearch(string userId, string sort, string roleId)
        {
            List<user> list = new List<user>();
            var query = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where user.LastName == userId || user.FirstName == userId
                        || user.Email == userId && user.role.RoleName == roleId
                        orderby user.FirstName
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };

            var query1 = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where user.LastName == userId || user.FirstName == userId
                        || user.Email == userId && user.role.RoleName == roleId
                        orderby user.FirstName
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };
            if (sort.Equals("user.FirstName"))
            {
                foreach (var roles in query)
                {
                    if (roles.RoleName.Equals(roleId))
                        list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
                }
                return list;
            }
            foreach (var roles in query1)
            {
                if (roles.RoleName.Equals(roleId))
                    list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
            }
            return list;
        }

        public List<user> userGridSearch(string userId, string roleId)
        {
            List<user> list = new List<user>();
            var query = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where user.LastName == userId || user.FirstName == userId
                        || user.Email == userId && user.RoleId == roleId
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };
            foreach (var roles in query)
            {
                if (roles.RoleName.Equals(roleId))
                    list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
            }
            return list;
        }

        public List<user> sortRole(string roleName)
        {
            List<user> list = new List<user>();
            var query = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where role.RoleName == roleName
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };
            foreach (var roles in query)
            {
                if (roles.RoleName.Equals(roleName))
                    list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
            }
            return list;
        }

        public List<user> sortRole(string roleName, string sort)
        {
            List<user> list = new List<user>();
            var query = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where user.role.RoleName == roleName
                        orderby user.FirstName
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };

            var query1 = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        where user.role.RoleName == roleName
                        orderby user.LastName
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };
            if (sort.Equals("user.FirstName"))
            {
                foreach (var roles in query)
                {
                    if (roles.RoleName.Equals(roleName))
                        list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
                }
                return list;
            }
            foreach (var roles in query1)
            {
                if (roles.RoleName.Equals(roleName))
                    list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
            }
            return list;
        }

        public List<user> sort(string sort)
        {
            List<user> list = new List<user>();
            var query = from user in db.user
                        join role in db.role on user.RoleId equals role.RoleId
                        orderby user.FirstName
                        select new { user.FirstName, user.LastName, user.Email, role.RoleName };

            var query1 = from user in db.user
                         join role in db.role on user.RoleId equals role.RoleId
                         orderby user.FirstName
                         select new { user.FirstName, user.LastName, user.Email, role.RoleName };
            if (sort.Equals("user.FirstName"))
            {
                foreach (var roles in query)
                {
                    list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
                }
                return list;
            }
            foreach (var roles in query1)
            {
                list.Add(new user(roles.FirstName, roles.LastName, roles.Email, roles.RoleName));
            }
            return list;
        }

        public user getUser(string email)
        {
            db.user.Load();
            List<user> users = db.user.Local.ToList();
            foreach (var user in users)
            {
                if (user.Email == email)
                {
                    MessageBox.Show(user.Email);
                    return user;
                }
            }
            return null;
        }
    }
}
