using MyRestFullApp.Api.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyRestFullApp.Api.Controllers
{
    public class UserController : ApiController
    {
        private EntitiesContext entities = new EntitiesContext();
        // GET: api/User
        public IEnumerable<User> Get()
        {
            IEnumerable<User> users = (from u in entities.Users
                                       select u).ToArray();
            return users;
        }

        // GET: api/User/5
        public User Get(int id)
        {
            var user = entities.Users.SingleOrDefault(u => u.Id == id);
            return user;
        }

        // POST: api/User
        public void Post([FromBody]User newUser)
        {
            entities.Users.Add(newUser);
            entities.SaveChanges();
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]User value)
        {
            Models.User user = entities.Users.SingleOrDefault(u => u.Id == id);
            user.Nombre = value.Nombre;
            user.Apellido = value.Apellido;
            user.Password = value.Password;
            user.Email = value.Email;
            entities.SaveChanges();
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
            entities.Users.RemoveWhere(u => u.Id == id);
        }
    }
}
