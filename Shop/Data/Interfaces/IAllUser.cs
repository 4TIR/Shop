using Microsoft.AspNetCore.Http;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Shop.Data.Interfaces
{
    public interface IAllUser
    {
        void createUser(User user);
      //  void signIn(User user);

       // private GetIdentity(string username,string password);



    }
}
