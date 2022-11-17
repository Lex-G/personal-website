using System;
using System.Threading.Tasks;
using SendGrid;
namespace Shared;

public interface IEmailService
{
  Task<bool> SendEmailWithResponseFromSupport();
}


public class EmailService : IEmailService
{

  private readonly ISendGridClient _sendGridClient;
  public EmailService(ISendGridClient sendGridClient)
  {
    _sendGridClient = sendGridClient;
  }
  public Task<bool> SendEmailWithResponseFromSupport()
  {

    throw new NotImplementedException();
  }

}
