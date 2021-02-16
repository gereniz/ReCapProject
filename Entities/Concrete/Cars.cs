using Core.Entities;

namespace Entities.Concrete
{
    public class Cars : IEntity
    {
        public int id { get; set; }
        public int brandid { get; set; }
        public int colorid { get; set; }
        public int modelyear { get; set; }
        public decimal dailyprice { get; set; }
        public string description { get; set; }

    }
}
