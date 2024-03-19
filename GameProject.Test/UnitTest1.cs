using Moq;
namespace GameProject.Test;

public class GameController
{
	private IList<IPlayer> _players;

	public GameController(IList<IPlayer> players)
	{
		_players = players;
	}

	public IList<IPlayer> GetListPlayers()
	{
		return _players;
	}
}
public interface IPlayer
{
	int Level{ get; set; }
	int ID { get; set; }
	string GetName();
	bool SetName(string name);
}

[TestFixture]
public class GameControllerTests
{
    [Test]
    public void GetListPlayers_ReturnRegisteredPlayers_PlayersAddedOnConstructor(){
        // 3A
        // Arrange

        // // why mock IPlayer? because actually what we want to test is GetPlayers thus needed GameController's constructor
        // but it needs interface IPlayer (which it doesn't have implementation in this case)
        Mock<IPlayer> player1 = new Mock<IPlayer>();
        player1.SetupProperty(u => u.ID, 123);
        player1.Setup(p => p.GetName()).Returns("Yanto");
        //player2.Setup(p => p.SetName(It.IsAny<string>())).Returns(true);

        Mock<IPlayer> player2 = new Mock<IPlayer>();
        player2.Setup(p => p.GetName()).Returns("Pandu");

        List<IPlayer> players = new();
        players.Add(player1.Object);
        players.Add(player2.Object);

        // // this is where it needs the constructor
        GameController game = new GameController(players);
        
        
        // Action
		IList<IPlayer> result = game.GetListPlayers();
		
		//Assert
		Assert.AreEqual(2, result.Count);
		Assert.AreEqual("Yanto", result[0].GetName());
		Assert.AreEqual("Pandu", result[1].GetName());
    }
}