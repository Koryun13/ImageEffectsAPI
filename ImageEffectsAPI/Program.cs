using ImageEffectsAPI.Plugins;

namespace ImageEffectsAPI.Services;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                // Adding Services
                services.AddControllers();
                services.AddScoped<ImageProcessor>();
                services.AddScoped<IEffectImage, ResizePlugin>();
                services.AddScoped<IEffectImage, BlurPlugin>();
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                // Configuring web host here 
                webBuilder.Configure(app =>
                {
                    if (app.ApplicationServices.GetRequiredService<IWebHostEnvironment>().IsDevelopment())
                        app.UseDeveloperExceptionPage();

                    app.UseRouting();

                    app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
                });
            });
    }
}