using Microsoft.Extensions.Configuration;
using System.IO;

namespace FrameworkEntity.CodeFirst
{
    public class Initializer
    {
        public static IConfigurationRoot Configuration;

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
        }
    }
}
