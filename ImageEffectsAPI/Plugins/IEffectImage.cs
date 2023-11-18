using ImageEffectsAPI.Models;

namespace ImageEffectsAPI.Plugins
{
    public interface IEffectImage
    {
        void ApplyEffect(Image image, Dictionary<string, object> parameters);
    }
}
