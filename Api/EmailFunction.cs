using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Core;
using System.Threading.Tasks;
using System.Text.Json;

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
  public async Task<IActionResult> SendEmail([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req)
  {
    var emailRequest = await JsonSerializer.DeserializeAsync<EmailRequest>(req.Body);
    var success = await _emailService.SendEmailWithResponse(emailRequest);
    if (success)
    {
      return new OkObjectResult(new { Status = "ok" });
    }
    else
    {
      return new UnprocessableEntityObjectResult(new { Status = "no" });
    }
  }
}