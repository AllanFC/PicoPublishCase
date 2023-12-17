using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;
using MVC.Models.Domain;

namespace MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext dataContext;

        public ProductsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, string sort = "ASC", string filter = "")
        {
            IQueryable<Product> productsQuery = dataContext.Products; 

            if (!string.IsNullOrEmpty(filter))
            {
                productsQuery = productsQuery.Where(p => p.Name.Contains(filter) ||
                (p.Description != null && p.Description.Contains(filter)));
            }

            if (sort.Equals("ASC"))
            {
                productsQuery = productsQuery.OrderBy(p => p.Name);
            }
            else
            {
                productsQuery = productsQuery.OrderByDescending(p => p.Name);
            }

            var products = await productsQuery.ToListAsync();

            int pageSize = 10;

            var pagedProducts = products.Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

            int totalPages = (int)Math.Ceiling((decimal)products.Count / pageSize);

            ProductsViewModel productsViewModel = new ProductsViewModel()
            {
                Page = page,
                PagedProducts = pagedProducts,
                TotalPages = totalPages,
                Sorting = sort,
                Filter = filter
            };

            return View(productsViewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel addProductRequest)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = addProductRequest.Name,
                Description = addProductRequest.Description
            };

            await dataContext.Products.AddAsync(product);
            await dataContext.SaveChangesAsync();

            return RedirectToAction("Add");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? Id)
        {
            var product = await dataContext.Products.FirstOrDefaultAsync(x => x.Id == Id);
            if(product == null)
            {
                return RedirectToAction("Index");
            }

            return View("Edit",product);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {

            var oldProduct = await dataContext.Products.FirstOrDefaultAsync(x => x.Id == product.Id);
            if(oldProduct == null)
            {
                return RedirectToAction("index");
            }
            oldProduct.Name = product.Name;
            oldProduct.Description = product.Description;
            await dataContext.SaveChangesAsync();

            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid? Id)
        {
            var product = await dataContext.Products.FirstOrDefaultAsync(x => x.Id == Id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            dataContext.Products.Remove(product);
            await dataContext.SaveChangesAsync();

            return RedirectToAction("index");
        }
    }
}
