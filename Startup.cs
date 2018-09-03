using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add any custom services here
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}