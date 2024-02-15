namespace MailSimulator;

public class User
{
    public string Address { get; private set; }
    public List<Mail> ListOfMailsReceived {
        get;
        set;
    }
    public List<Mail> ListOfMailsSent {
        get;
        set;
    }

    public User(string address)
    {
        Address = address;
        ListOfMailsReceived = new List<Mail>();
        ListOfMailsSent = new List<Mail>();
    }

    public User(string address, List<Mail> listOfMails)
    {
        Address = address;
        ListOfMailsReceived = new List<Mail>();
        ListOfMailsSent = new List<Mail>();
        foreach (Mail mail in listOfMails)
        {
            if (mail.Sender != null && mail.Sender.Equals(this))
                ListOfMailsSent.Add(mail);
            else if (mail.Receiver != null && mail.Receiver.Contains(this))
            {
                ListOfMailsReceived.Add(mail);
            }
        }
    }
    
    public User(string address, List<Mail> listOfMailsReceived, List<Mail> listOfMailsSent)
    {
        Address = address;
        ListOfMailsReceived = listOfMailsReceived;
        ListOfMailsSent = listOfMailsSent;
    }
    public override string ToString()
    {
        string allMails = "";
        for (int i = 0; i < ListOfMailsReceived.Count; i++)
        {
            allMails += "\n****************************************************************************\n";
            allMails += ListOfMailsReceived[i];
            if (i < ListOfMailsReceived.Count - 1)
                allMails += "\n";
        }
        
        string toReturn = $"{Address}\n" +
                          $"Number of mails: {ListOfMailsReceived.Count}";
        if (allMails.Length != 0)
        {
            toReturn += "\n";
            toReturn += allMails;
        }
        return toReturn;
    }
    
}