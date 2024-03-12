namespace Builder.Email;

public class Email
{
    public string From { get; set; } = null!;
    public string To { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string Body { get; set; } = null!;

    public override string ToString()
    {
        return $"To:{To}\nFrom:{From}\nSubject:\n{Subject}\n{Body}";
    }
}