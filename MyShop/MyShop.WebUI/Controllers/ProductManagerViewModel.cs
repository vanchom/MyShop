using System.Linq;
using MyShop.Core.Models;

namespace MyShop.WebUI.Controllers
{
    public partial class ProductManagerController
    {
        private class ProductManagerViewModel
        {
            internal Product product;

            public IQueryable<ProductCategory> productCategories { get; internal set; }
        }
    }
}