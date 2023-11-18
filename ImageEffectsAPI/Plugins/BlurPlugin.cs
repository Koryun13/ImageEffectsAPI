using ImageEffectsAPI.Models;

namespace ImageEffectsAPI.Plugins
{
    public class BlurPlugin : IEffectImage
    {
        public void ApplyEffect(Image image, Dictionary<string, object> parameters)
        {
            if (parameters.ContainsKey("Size"))
            {
                // Should be a code of blur logic 
            }
        }
    }
}
