using Microsoft.Extensions.Hosting;
using SendGrid;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Core;

[assembly: FunctionsStartup(typeof(Api.Startup))]

namespace Api;


public class Startup : FunctionsStartup
{
  public override void Configure(IFunctionsHostBuilder builder)
  {

    var sendGridApiKey = "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";
    builder.Services.AddSingleton<ISendGridClient>(_ => new SendGridClient(sendGridApiKey));
    builder.Services.AddScoped<IEmailService, EmailService>();
  }

}

