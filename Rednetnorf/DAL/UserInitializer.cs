using System.Collections.Generic;
using Rednetnorf.Models;

namespace Rednetnorf.DAL
{
    public class UserInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
                new User{Username="4ugun123", Password="4ugun123"},
                new User{Username="m1go", Password="m1go"},
            };

            users.ForEach(user => context.Users.Add(user));
            context.SaveChanges();
        }
    }
}
