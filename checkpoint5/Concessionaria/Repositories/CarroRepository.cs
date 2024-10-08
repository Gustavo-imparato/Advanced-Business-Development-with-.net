using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

public class CarroRepository : ICarroRepository
{
    private readonly IMongoCollection<Carro> _carrosCollection;

    public CarroRepository(IOptions<MongoDbSettings> mongoDbSettings)
    {
        var mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(mongoDbSettings.Value.Database);
        _carrosCollection = mongoDatabase.GetCollection<Carro>("carros");
    }

    public async Task<IEnumerable<Carro>> GetAllAsync()
    {
        return await _carrosCollection.Find(_ => true).ToListAsync();
    }

    public async Task<Carro> GetByIdAsync(string id)
    {
        return await _carrosCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task AddAsync(Carro carro)
    {
        await _carrosCollection.InsertOneAsync(carro);
    }

    public async Task UpdateAsync(string id, Carro carro)
    {
        await _carrosCollection.ReplaceOneAsync(x => x.Id == id, carro);
    }

    public async Task DeleteAsync(string id)
    {
        await _carrosCollection.DeleteOneAsync(x => x.Id == id);
    }
}
