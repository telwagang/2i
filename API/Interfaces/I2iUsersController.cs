using API.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Interfaces
{
    public interface I2iUsersController
    {
        List<_2iUsers> GetAllUsers();

        void Insert(_2iUsers user);
        void Update(_2iUsers user); 
    }
}
