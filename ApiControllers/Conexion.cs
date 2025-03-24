using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("conexion")]
public class Conexion : Controller {
 [HttpGet("mongo")]
 public IActionResult ListarSalonesMongoDb(){
   MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
   var db = client.GetDatabase("4D-Eduardo-Anita");
   var collection = db.GetCollection<ComidaRapida>("Comida Rápida");

   var lista = collection.Find(FilterDefinition<ComidaRapida>.Empty).ToList();
    return Ok (lista);
 }
}