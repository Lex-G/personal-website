using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Shared;

namespace Api;

public class EmailFunction
{
  private readonly ILogger _logger;
  private readonly IEmailService _emailService;
  public EmailFunction(ILoggerFactory loggerFactory, IEmailService emailService)
  {
    _logger = loggerFactory.CreateLogger<EmailFunction>();
    _emailService = emailService;
  }

  [FunctionName(nameof(SendEmail))]
  public static IActionResult SendEmail([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
  {
    return new OkObjectResult(new { });
  }
}