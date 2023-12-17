using MVC.Models.Domain;

namespace MVC.Models
{
    public class ProductsViewModel
    {
        public List<Product> PagedProducts { get; set; }
        public int TotalPages { get; set; }
        public int Page { get; set; }
        public string Sorting { get; set; }
        public string Filter { get; set; }

    }
}
