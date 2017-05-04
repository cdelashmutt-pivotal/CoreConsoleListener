using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace CoreConsoleListener
{
    public class Program
    {
        public static void Main(string[] args)
        {
	    var config = new ConfigurationBuilder()
                .AddCommandLine(args)
		.Build();

            Console.WriteLine("Starting!");
	    var host = new WebHostBuilder()
	        .UseKestrel()
		.UseConfiguration(config)
		.UseStartup<Startup>()
		.Build();
	    host.Run();
        }
    }
}
