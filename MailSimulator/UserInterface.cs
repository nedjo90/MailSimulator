namespace MailSimulator;

public class UserInterface
{
    public void Start()
    {
        ConsoleColorManager.BackBlackForeBlue();
        while (ConnectionMenu() == CoMenu.Connect)
        {
            User? userOnline = Connection();
            if (userOnline != null)
                Navigation(userOnline);
        }
    }

    public void Navigation(User user)
    {
        NavMenu choice;
        while ((choice = NavigationMenu()) != NavMenu.Quit)
        {
            if (choice == NavMenu.DisplayReceivedMails)
                MailManager.DisplayUserMailsReceived(user);
            else if (choice == NavMenu.DisplaySentMails )
                MailManager.DisplayUserMailsSent(user);
            else if (choice == NavMenu.SendMail)
                MailManager.SendMail(user);
        }
    }

    public NavMenu NavigationMenu()
    {
        NavMenu choice = NavMenu.Invalid;
        while (choice == NavMenu.Invalid)
        {
            Console.WriteLine($"Please Make a choice: \n" +
                              $"1 - All received e-mails\n" +
                              $"2 - All sent e-mails\n" +
                              $"3 - Send an e-mail\n" +
                              $"0 - {NavMenu.Quit}");
            string? answer = Console.ReadLine();
            try
            {
                int choiceConvertInt = Convert.ToInt32(answer);
                if (Enum.IsDefined(typeof(NavMenu), choiceConvertInt))
                    choice = (NavMenu)choiceConvertInt;
            }
            catch (Exception e)
            {
                Console.Error.Write(e + ": error menu choice");
                throw;
            }

            if (choice == NavMenu.Invalid)
                MailManager.DisplayInvalidChoice();                
        }

        return choice;
    }
    public User? Connection()
    {
        User? userOnline = MailManager.ConnectionToAddress();
        if (userOnline == null)
            return null;
        Console.Clear();
        Console.WriteLine($"Welcome {userOnline.Address} ✉️");
        return userOnline;
    }
    public CoMenu ConnectionMenu()
    {
        CoMenu choice = CoMenu.Invalid;
        while (choice == CoMenu.Invalid)
        {
            Console.Clear();
            Console.WriteLine("Welcome to your e-mail services");
            Console.WriteLine($"Please make a choice:\n" +
                              $"1 - {CoMenu.Connect}\n" +
                              $"0 - {CoMenu.Quit}");
            string? answer = Console.ReadLine();
            try
            {
                int choiceConvertInt = Convert.ToInt32(answer);
                if (Enum.IsDefined(typeof(CoMenu), choiceConvertInt))
                    choice = (CoMenu)choiceConvertInt;
            }
            catch (Exception e)
            {
                Console.Error.Write(e + ": error menu choice");
                throw;
            }

            if (choice == CoMenu.Invalid)
                MailManager.DisplayInvalidChoice();
        }
        return choice;
    }
}