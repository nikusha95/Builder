namespace Builder.Email;

public class MailService
{
    private void SendEmailInternal()
    {
    }

    public void SendEmail(Action<EmailBuilder> builder)
    {
        var email = new Email();
        builder(new EmailBuilder(email));
        SendEmailInternal();
    }
}