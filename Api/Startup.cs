using Microsoft.Extensions.Hosting;
using SendGrid;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Core;
using System;

[assembly: FunctionsStartup(typeof(Api.Startup))]

namespace Api;


public class Startup : FunctionsStartup
{
  public override void Configure(IFunctionsHostBuilder builder)
  {
   
    var sendGridApiKey = System.Environment.GetEnvironmentVariable("sendGridApiKey");
    builder.Services.AddSingleton<ISendGridClient>(_ => new SendGridClient(sendGridApiKey));
    builder.Services.AddScoped<IEmailService, EmailService>();
  }

}

