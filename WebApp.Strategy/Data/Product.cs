using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApp.Strategy.Data;

public class Product
{
    [BsonId]
    [Key]
    [BsonRepresentation(BsonType.ObjectId)]
    public required string Id { get; set; }

    public required string Name { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    [BsonRepresentation(BsonType.Decimal128)]
    public decimal Price { get; set; }

    public int Stock { get; set; }
    public required string UserId { get; set; }

    [BsonRepresentation(BsonType.DateTime)]
    public DateTime CreatedOn { get; set; }
}