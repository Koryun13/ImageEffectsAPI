using ImageEffectsAPI.Models;
using ImageEffectsAPI.Plugins;

namespace ImageEffectsAPI.Services;

public class ImageProcessor
{
    private readonly List<IEffectImage> plugins = new();

    public void AddPlugin(IEffectImage plugin)
    {
        plugins.Add(plugin);
    }

    public void RemovePlugin(IEffectImage plugin)
    {
        plugins.Remove(plugin);
    }

    public void ApplyEffects(Image image)
    {
        foreach (var effect in image.Effects)
        foreach (var plugin in plugins)
            if (string.Equals(effect.Type, plugin.GetType().Name))
            {
                plugin.ApplyEffect(image, effect.Parameters);
                break;
            }
    }
}