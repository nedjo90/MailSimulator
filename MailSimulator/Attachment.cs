namespace MailSimulator;

public class Attachment
{
    public string File { get; private set; }

    public Attachment(string file)
    {
        File = file;
    }
}