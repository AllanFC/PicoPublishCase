using System.ComponentModel.DataAnnotations;

namespace MVC.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

        public Product(string name, string? description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }
    }
}
