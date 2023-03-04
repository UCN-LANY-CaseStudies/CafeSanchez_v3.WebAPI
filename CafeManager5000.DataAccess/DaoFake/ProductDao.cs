using CafeManager5000.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager5000.DataAccess.DaoFake
{
    internal class ProductDao : IDao<Product>
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Americano", Description= "Espresso shots topped with hot water create a light layer of crema culminating in this wonderfully rich cup with depth and nuance.", Price = 22.50M},
            new Product { Id = 2, Name = "Dark Roast Coffee", Description= "This full-bodied dark roast coffee with bold, robust flavors showcases our roasting and blending artistry—an essential blend of balanced and lingering flavors.", Price = 32.50M},
            new Product { Id = 3, Name = "Misto", Description= "A one-to-one combination of fresh-brewed coffee and steamed milk add up to one distinctly delicious coffee drink remarkably mixed.", Price = 32.50M},
            new Product { Id = 4, Name = "Cappuccino", Description= "Dark, rich espresso lies in wait under a smoothed and stretched layer of thick milk foam. An alchemy of barista artistry and craft. ", Price = 29.50M},
            new Product { Id = 5, Name = "Espresso", Description= "Our smooth signature Espresso Roast with rich flavor and caramelly sweetness is at the very heart of everything we do.", Price = 19.50M},
            new Product { Id = 6, Name = "Latte", Description= "Our dark, rich espresso balanced with steamed milk and a light layer of foam. A perfect milk-forward warm-up.", Price = 29.50M},
            new Product { Id = 7, Name = "Cinnamon Dolce Latte", Description= "We add freshly steamed milk and cinnamon dolce-flavored syrup to our classic espresso, topped with sweetened whipped cream and a cinnamon dolce topping to bring you specialness in a treat.", Price = 32.50M},
            new Product { Id = 8, Name = "Flat White", Description= "Smooth ristretto shots of espresso get the perfect amount of steamed whole milk to create a not-too-strong, not-too-creamy, just-right flavor.", Price = 29.50M},
            new Product { Id = 9, Name = "Caramel Macchiato", Description= "Freshly steamed milk with vanilla-flavored syrup marked with espresso and topped with a caramel drizzle for an oh-so-sweet finish.", Price = 29.50M},
        };

        public Product Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ReadAll()
        {
            return _products;
        }

        public bool Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
