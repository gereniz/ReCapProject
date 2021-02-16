using Core.Entities;

namespace Entities.Concrete
{
    public class Colors : IEntity
    {
        public int id { get; set; }
        public string colorname { get; set; }
    }
}
