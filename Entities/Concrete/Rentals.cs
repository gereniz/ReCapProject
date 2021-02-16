using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Rentals : IEntity
    {
        public int id { get; set; }
        public int customerid { get; set; }
        public int carid { get; set; }
        public DateTime rentdate { get; set; }
        public DateTime returndate { get; set; }
    }
}
