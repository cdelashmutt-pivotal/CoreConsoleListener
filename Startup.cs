using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
 
namespace CoreConsoleListener {
    public class Startup{
        public void Configure(IApplicationBuilder app){
            app.Run(async context => {
		context.Response.ContentType = "application/json";	    
                await context.Response.WriteAsync("{\"status\": \"ok\"}");
            });
        }
    }
}
