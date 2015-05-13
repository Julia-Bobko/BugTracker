using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BugTracker.Repository
{
    public class UserRepository
    {
        private string ConnectionString = "Data Source=juli;Initial Catalog=bagTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

       // public List<User> users = new List<User>{
       // new User
       // {
       //     IdUser =1,
       //     FullName ="Shitov",
       //     ImagePath = "app/img/1.png",
       //     EmailAddress="shitov@mail.ru",
       //     Password="111"
       // },
       // new User 
       // {
       //     IdUser = 2,
       //     FullName ="Yarov",
       //     ImagePath = "app/img/2.png",
       //     EmailAddress="yarov@mail.ru",
       //     Password="yarov"
       // },
       // new User 
       // {
       //     IdUser=3,
       //     FullName = "Сhernov",
       //     ImagePath = "app/img/3.png",
       //     EmailAddress="Сhernov@mail.ru",
       //     Password="chernov"
       // },
       // new User 
       // {
       //     IdUser = 4,
       //     FullName = "Belyaeva",
       //     ImagePath = "app/img/4.png",
       //     EmailAddress="belyaeva@mail.ru",
       //     Password="belyaeva"       
       // },
       // new User
       // {
       //     IdUser = 5,
       //     FullName ="Schukin",
       //     ImagePath = "app/img/5.png",
       //     EmailAddress="schukin@mail.ru",
       //     Password="schukin"
       // }
       //};

        public List<User> GetUsers() 
        {
            var sql = String.Format(@"SELECT * FROM users");
            using (var conn = new SqlConnection(ConnectionString))
            {
                var listComments = conn.Query<User>(sql).ToList();
                return listComments;
            }
            //return users;
        }

        //public bool IsUser(string fullname)
        //{
        //    var matches = users.Where(x => x.FullName == fullname);
        //    return matches.Count() > 0 ? true : false;
        //}

        //public void CreateAccount(User user)
        //{
        //   if (!IsUser(user.FullName))
        //    {
        //        user.IdUser = users.Count + 1;
        //        users.Add(user);               
        //    }           
        //}

        //public bool LogIn(string fullName, string password) 
        //{
        //    var matches = users.Where(x => x.FullName == fullName && x.Password==password);
        //    return matches.Count() > 0 ? true : false;          
        //}
    }
}
