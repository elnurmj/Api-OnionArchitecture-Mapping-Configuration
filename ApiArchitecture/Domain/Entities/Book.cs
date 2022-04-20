using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Page { get; set; }
    }
}
