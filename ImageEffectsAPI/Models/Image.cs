namespace ImageEffectsAPI.Models
{
    public class Image
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Effect> Effects { get; set; } = new List<Effect>();
    }
}
