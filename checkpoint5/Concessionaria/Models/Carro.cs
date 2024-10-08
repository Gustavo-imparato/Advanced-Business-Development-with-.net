using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Carro
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; } // Mude de int para string

    [BsonElement("Marca")]
    public string? Marca { get; set; }

    [BsonElement("Modelo")]
    public string? Modelo { get; set; }

    [BsonElement("Ano")]
    public int Ano { get; set; }

    [BsonElement("Preco")]
    public decimal Preco { get; set; }
}
