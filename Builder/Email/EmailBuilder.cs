namespace Builder.Email;

public class EmailBuilder(Email email)
{
    private readonly Email _email = email;

    public EmailBuilder From(string from)
    {
        _email.From = from;
        return this;
    }

    public EmailBuilder To(string to)
    {
        _email.To = to;
        return this;
    }

    public EmailBuilder WithSubject(string subject)
    {
        _email.Subject = subject;
        return this;
    }

    public EmailBuilder WithBody(string body)
    {
        _email.Body = body;
        return this;
    }
}