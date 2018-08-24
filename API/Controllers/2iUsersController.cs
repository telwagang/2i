using API.Interfaces;
using API.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Controllers
{
    internal class _2iUsersController : I2iUsersController
    {
        private readonly IContext _ctx; 

        public _2iUsersController(IContext context)
        {
            _ctx = context; 
        }

        public List<_2iUsers> GetAllUsers()
        {
            return _ctx.GetCollection<_2iUsers>();
        }

        public void Insert(_2iUsers user)
        {
            user._id = Guid.NewGuid(); 
            _ctx.Add(user); 
        }

        public void Update(_2iUsers user)
        {
            _ctx.Update(user);
        }
    }
}
