using GameControllerLib;
using log4net;
using log4net.Config;

public class Program 
{
    private static readonly ILog log = LogManager.GetLogger(typeof(Program));

    static void Main(string[] args) 
    {
        // Set up a simple configuration that logs on the console.

        // BasicConfigurator.Configure();
        XmlConfigurator.Configure(new System.IO.FileInfo(args[0]));
        Card card0 = new(0, "card zero");
        Card card1 = new(1, "card one");
        Card card2 = new(2, "card two");

        log.Info("Entering application.");
        
        
        ICard[] cards1 = new ICard[3] {card0, card1, card2};
        log.Info("3 instance of Card has been Made.");
        
        Player player1 = new("player one");
        log.Info($"New player {player1.GetName()} has been made.");
        
        
        Board board = new(4);
        log.Info($"New Board {board.GetSize()}(size) has been made.");


        GameController gc = new(player1, board);

        
        gc.AddCards(player1, cards1);


        gc.GetCards(player1);
        

        gc.RemoveCard(player1, card0);
        

        log.Info("Exiting application.");
    }
}