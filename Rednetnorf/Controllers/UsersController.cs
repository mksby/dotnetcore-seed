using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Rednetnorf.DAL;
using System.Linq;

namespace Rednetnorf.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private UserContext db = new UserContext();

        [HttpGet]
        public IEnumerable Users()
        {
            return db.Users.ToList();
        }
    }
}
