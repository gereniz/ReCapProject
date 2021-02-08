using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int id { get; set; }
        public string brandname { get; set; }

    }
}
