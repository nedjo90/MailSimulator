namespace MailSimulator;

public class Mail
{
    public Mail? Previous { get; }
    public User? Sender { get; }
    public List<User>? Receiver { get; private set; }

    public string? MessageObject { get; private set; }
    public string? Message { get; private set; }
    public List<Attachment>? ListOfAttachments { get; private set; }
    
    public DateTime? Date { get; private set; }
    
    public Mail()
    {
    }
    
    //A new new mail without history
    public Mail(User sender, List<User> receiver,string messageObject, string message, List<Attachment> attachments)
    {
        Previous = new Mail();
        Sender = sender;
        Receiver = receiver;
        MessageObject = messageObject;
        Message = message;
        ListOfAttachments = attachments;
        Date = DateTime.Now;
    }
    
    //Answer to a mail, we put the previous messages
    public Mail(Mail previous, User sender, List<User> receiver,string messageObject, string message, List<Attachment> attachments)
    {
        Previous = previous;
        Sender = sender;
        Receiver = receiver;
        MessageObject = messageObject;
        Message = message;
        ListOfAttachments = attachments;
        Date = DateTime.Now;
    }
    public override string ToString()
    {
        string receivers = "";
        if(Receiver != null)
        {
            foreach (User user in Receiver)
            {
                receivers += user.Address + ";";
            }
        }
        string attachments = "";
        if (ListOfAttachments != null)
        {
            foreach (Attachment file in ListOfAttachments)
            {
                attachments += file.File + ";";
            }
        }
        string mailInfo = $"({Date})\t" +
                          $"From: {Sender!.Address}\n\n" +
                          $"To: {receivers}\n" +
                          $"\n->Object: {MessageObject}\n" +
                          $"\nMessage:\n\n{Message}\n" +
                          $"Attachments : {attachments}";
        return mailInfo;
    }
}