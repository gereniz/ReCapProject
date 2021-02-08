using System;
namespace Entities.DTOs
{
    public class CarDetailDTO
    {
        public int id { get; set; }
        public string brandname { get; set; }
        public string colorname { get; set; }
        public int modelyear { get; set; }
        public decimal dailyprice { get; set; }
        public string description { get; set; }
    }
}
