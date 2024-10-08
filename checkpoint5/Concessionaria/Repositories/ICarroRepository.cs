using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICarroRepository
{
    Task<IEnumerable<Carro>> GetAllAsync();
    Task<Carro> GetByIdAsync(string id);
    Task AddAsync(Carro carro);
    Task UpdateAsync(string id, Carro carro);
    Task DeleteAsync(string id);
}
