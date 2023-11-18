namespace ImageEffectsAPI.Models
{
    public class Effect
    {
        public string Type { get; set; }
        public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();
    }
}
