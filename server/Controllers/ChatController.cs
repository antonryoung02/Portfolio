using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    [HttpGet("getMessage")]
    public IActionResult GetMessage()
    {
        var message = new
        {
            Text = "Hello, this is a JSON response!",
            Timestamp = DateTime.UtcNow
        };

        return Ok(message); // Automatically serialized to JSON
    }
}