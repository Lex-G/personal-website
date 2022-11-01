using Microsoft.Extensions.Hosting;
using SendGrid;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Shared;

[assembly: FunctionsStartup(typeof(Api.Startup))]

namespace Api;


public class Startup : FunctionsStartup
{
  public override void Configure(IFunctionsHostBuilder builder)
  {
    var sendGridApiKey = "";
    builder.Services.AddSingleton<ISendGridClient>(_ => new SendGridClient(sendGridApiKey));
    builder.Services.AddScoped<IEmailService, EmailService>();
  }
}
// public class Program
// {
//   public static void Main()
//   {
//     var host = new HostBuilder()
//         .ConfigureFunctionsWorkerDefaults()
//         .ConfigureServices(services =>
//         {
//           var sendGridApiKey = "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";
//           services.AddSingleton<ISendGridClient>(_ => new SendGridClient(sendGridApiKey));
//           services.AddScoped<IEmailService, EmailService>();
//         })
//         .Build();

//     host.Run();
//   }
// }

