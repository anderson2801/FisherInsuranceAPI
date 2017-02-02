using Microsoft.AspNetCore.Mvc;

[Route("api/home/claim")]
public class ClaimsController : Controller {

    // POST api/home/claim
    [HttpPost]
    public IActionResult Post([FromBody]string value) {
        return Created("", value);
    }

    // GET api/home/claim/5
    [HttpGet("{id}")]
    public IActionResult Get(int id) {
           return Ok("The id is: " + id);
       }

       // PUT api/home/claim/id
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]string value) {
        return NoContent();
    }

// DELETE api/home/claim/id
       [HttpDelete("{id}")]
    public IActionResult Delete(int id) {
      return Delete(id);
    }
}