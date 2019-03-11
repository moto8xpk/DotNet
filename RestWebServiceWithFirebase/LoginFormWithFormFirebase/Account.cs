﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFormWithFormFirebase
{
    class Account
    {
        public Int32 Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public Account(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        public Account()
        {
        }
    }
}
