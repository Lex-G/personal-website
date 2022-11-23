using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
namespace Core;

public interface IEmailService
{
  Task<bool> SendEmailWithResponse(EmailRequest emailRequest);
}


public class EmailService : IEmailService
{

  private readonly ISendGridClient _sendGridClient;
  private readonly EmailAddress _supportEmail = new EmailAddress("support@lithe.technology", "Support");
  private readonly EmailAddress _lexEmail = new EmailAddress("lex@lithe.technology", "Lex");

  public EmailService(ISendGridClient sendGridClient)
  {
    _sendGridClient = sendGridClient;
  }
  public async Task<bool> SendEmailWithResponse(EmailRequest emailRequest)
  {
    try
    {
      var requesterEmail = new EmailAddress(emailRequest.Email, emailRequest.Name);
      var subject = emailRequest.Subject;
      var plainTextContent = $@"{emailRequest.Message} -
      Primary Phone Number {emailRequest.PhoneNumber}";
      var htmlContent = $@"{emailRequest.Message}
      <br>Primary Phone Number {emailRequest.PhoneNumber}";
      var requesterMessage = MailHelper.CreateSingleEmail(_supportEmail, _lexEmail, subject, plainTextContent, htmlContent);
      requesterMessage.SetReplyTo(requesterEmail);
      var sendGridResponse = await _sendGridClient.SendEmailAsync(requesterMessage);
      if (!sendGridResponse.IsSuccessStatusCode)
      {
        throw new Exception("Unable to send e-mail.");
      }
      _ = Task.Run(async () =>
      {
        await SendInstantEmailReplyToLead(emailRequest, requesterEmail, requesterMessage);
      });
      return true;
    }
    catch (System.Exception)
    {
      return false;
    }
  }

  private async Task SendInstantEmailReplyToLead(EmailRequest emailRequest, EmailAddress requesterEmail, SendGridMessage requesterMessage)
  {
    var emailResponseSubject = $"Re: {emailRequest.Subject}";
    var emailResponsePlainMessage = $@"Hello {emailRequest.Name},

                                                   I have received your message. Responses can take up to twenty four hours.

                                                   Thank you,
                                                   Lex";

    var emailResponseHtmlMessage = $@"Hello {emailRequest.Name},
                                                   <br><br>I have received your message. Responses can take up to twenty four hours.
                                                   <br><br>Thank you,
                                                   <br>Lex";

    var emailResponseToCustomerFromSupport = MailHelper.CreateSingleEmail(_supportEmail, requesterEmail, emailResponseSubject,
        emailResponsePlainMessage, emailResponseHtmlMessage);
    requesterMessage.SetBccSetting(true, _lexEmail.Email);
    requesterMessage.AddBcc(_lexEmail);
    requesterMessage.SetReplyTo(_lexEmail);

    var sendEmailResponseToCustomerFromSupport =
        await _sendGridClient.SendEmailAsync(emailResponseToCustomerFromSupport);

    if (!sendEmailResponseToCustomerFromSupport.IsSuccessStatusCode)
    {
      Console.Write("did not send customer an instant reply");
    }
  }

}
