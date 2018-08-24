using API.Helpers;
using API.Interfaces;
using API.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _2i.Controllers
{
    public class FormsController : ApiController
    {
        [HttpPost]
        public void Insert([FromBody] _2iUsers u)
        {
            if (ModelState.IsValid)
            {
                Sys.Get<I2iUsersController>().Insert(u); 
            }
        }
    }
}
