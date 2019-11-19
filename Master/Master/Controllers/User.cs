using System;

namespace Master.Controllers
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public Guid Id { get; set; }
        public string Username { get; set; }
    }
}