using ImageEffectsAPI.Models;
using ImageEffectsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ImageEffectsAPI.Controllers;

[ApiController]
[Route("api/images")]
public class ImageController : ControllerBase
{
    private readonly ImageProcessor imageProcessor;

    public ImageController(ImageProcessor imageProcessor)
    {
        this.imageProcessor = imageProcessor;
    }

    [HttpPost("process")]
    public IActionResult ProcessImage([FromBody] Image image)
    {
        imageProcessor.ApplyEffects(image);
        return Ok(image); // here should be an image
    }
}