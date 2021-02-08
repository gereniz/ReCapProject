using Core.Entities;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int id { get; set; }
        public string colorname { get; set; }
    }
}
