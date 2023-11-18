using ImageEffectsAPI.Models;

namespace ImageEffectsAPI.Plugins;

public class ResizePlugin : IEffectImage
{
    public void ApplyEffect(Image image, Dictionary<string, object> parameters)
    {
        if (parameters.ContainsKey("Width") && parameters.ContainsKey("Height"))
        {
            image.Width = (int)parameters["Width"];
            image.Height = (int)parameters["Height"];

            // Should be a code of resize logic
        }
    }
}