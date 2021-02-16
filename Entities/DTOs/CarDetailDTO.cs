using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailDTO : IDTO
    {
        public int id { get; set; }
        public string brandname { get; set; }
        public string colorname { get; set; }
        public int modelyear { get; set; }
        public decimal dailyprice { get; set; }
        public string description { get; set; }
    }
}
