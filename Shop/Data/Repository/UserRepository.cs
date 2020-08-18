using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;
using System.Collections.Generic;

namespace Shop.Data.Repository
{
    public class UserRepository : IAllUser 
    {
        private readonly AppDBContent appDBContent;
        public UserRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public void createUser(User user)
        {

            var login = appDBContent.User

                   .Where(b => b.Email == user.Email).FirstOrDefault();
                   



            if (login!=null)
           {
                throw new Exception("This email already exists in database");
               
           }

            else
            {
                appDBContent.User.Add(user);
                appDBContent.SaveChanges();

            }
        }
        

        //  public IEnumerable<User> AllUsers => appDBContent.User;
    }
}
