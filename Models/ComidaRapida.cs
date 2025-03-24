using MongoDB.Bson.Serialization.Attributes;

public class ComidaRapida {
[BsonId]
[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
 public string? Id { get; set; }
 public string NombreDelRestaurante { get; set; } = string.Empty;
 public string Comida { get; set; } = string.Empty;
 public string Ingredientes { get; set; } = string.Empty;
 public string Menu { get; set; } = string.Empty;
 public int Porcion { get; set; }
 public int Precio { get; set; }
 public int TiempoDeCoccionEnMinutos { get; set; }
 public int TiempoDeCoccionEnHoras { get; set; }
 public int TiempoDeRefrigeracionEnMinutos { get; set; }
 public int TiempoDeRefrigeracionEnHoras { get; set; }
 public int TiempoDeEsperaEnMinutos { get; set; }
 public decimal CalificacionEnEstrellas { get; set; } 
}