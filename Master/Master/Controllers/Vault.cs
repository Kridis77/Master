using System;
using System.Collections.Generic;

namespace Master.Controllers
{
    public static class Vault
    {
        public static Bankas TheBank = new Bankas();
        public static List<User> Users = new List<User>
        {
            new User
            {
                Username = "Vista",
                Name = "Stase",
                Id = Guid.NewGuid(),
                Password = "Saugumas",
                Surname = "Broilere"
            }
        };
    }
}