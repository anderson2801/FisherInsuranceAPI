using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/quotes")]
public class AutoController : Controller {
private IMemoryStore db;
public AutoController(IMemoryStore repo) {
    db = repo;
}
 
[HttpGet]
public IActionResult GetQuotes() {
    return Ok(db.RetrieveAllQuotes);
}
 
[HttpGet("{id}")]
public IActionResult Get(int id) {
    return Ok(db.RetrieveQuote(id));
}

[HttpPost]
public IActionResult Post([FromBody] Quote quote) {
    return Ok(db.CreateQuote(quote));
}

[HttpPut("{id}")]
public IActionResult Put([FromBody] Quote quote) {
    return Ok(db.UpdateQuote(quote));
}
 
[HttpDelete("{id}")]
public IActionResult Delete(int id) {
    db.DeleteQuote(id); 
    return Ok();
    }
}