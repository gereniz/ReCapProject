using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Users : IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
