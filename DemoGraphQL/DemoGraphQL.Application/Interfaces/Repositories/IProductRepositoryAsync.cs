using DemoGraphQL.Domain.Entities;
using System.Threading.Tasks;

namespace DemoGraphQL.Application.Interfaces.Repositories
{
    public interface IProductRepositoryAsync : IGenericRepositoryAsync<Products>
    {
        Task<bool> IsUniqueProductCodeAsync(string productCode);
    }
}
