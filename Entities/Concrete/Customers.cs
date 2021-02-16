using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customers :IEntity
    {
        public int id { get; set; }
        public int userid { get; set; }
        public string companyname { get; set; }
    }
}
