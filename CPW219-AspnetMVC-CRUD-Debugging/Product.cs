using System.Data.Entity;
using CPW219_AspnetMVC_CRUD_Debugging.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
namespace CPW219_AspnetMVC_CRUD_Debugging
{
    // My database wouldn't create at all. I have no idea why
    // I checked my intalled packages and everything seems to be there.
    // I also checked to see if it was linked to my models, it was.
    // I don't know another step to do this properly. This was my last step.
    [DbContext(typeof(ProductContext))]
    [Migration(nameof(ProductContext))]
    public class ProductContext : DbContext
    {
        public ProductContext(ProductContext context)
        {

        }
    }
}
