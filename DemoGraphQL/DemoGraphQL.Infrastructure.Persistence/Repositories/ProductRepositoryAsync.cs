using DemoGraphQL.Application.Interfaces.Repositories;
using DemoGraphQL.Domain.Entities;
using DemoGraphQL.Infrastructure.Persistence.Contexts;
using DemoGraphQL.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DemoGraphQL.Infrastructure.Persistence.Repositories
{
    public class ProductRepositoryAsync : GenericRepositoryAsync<Products>, IProductRepositoryAsync
    {
        private readonly DbSet<Products> _products;

        public ProductRepositoryAsync(VietbankDbContext dbContext) : base(dbContext)
        {
            _products = dbContext.Set<Products>();
        }

        public Task<bool> IsUniqueProductCodeAsync(string productCode)
        {
            return _products
                .AllAsync(p => p.ProductCode != productCode);
        }

        
    }
}
