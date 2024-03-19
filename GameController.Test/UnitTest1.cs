using Moq;
using GameControllerLib;
namespace GameControllerTest;

public class GameControllerTests
{
    GameController _game;
    Mock<IPlayer> _player;
    Mock<IBoard> _board;

    [SetUp]
    public void Setup()
    {
        _player = new Mock<IPlayer>();
        _board = new Mock<IBoard>();
        _game = new GameController(_player.Object, _board.Object);
    }

    [Test]
    // Positive testing
    public void AddCards_CardsAdded_PlayerExists(){
        // Arrange
        Mock<ICard> card = new Mock<ICard>();

        // Action
        bool result = _game.AddCards(_player.Object, card.Object);

        // Assert
        Assert.IsTrue(result);
        card.Verify(card => card.SetStatus(CardStatus.OnPlayer), Times.Once);
    }

    [Test]
    // Negative case
    public void AddCards_ReturnFalse_PlayerNotInCollection(){
        // Arrange
        Mock<ICard> card = new Mock<ICard>();
        Mock<IPlayer> otherPlayer = new Mock<IPlayer>();
        
        // Action
        bool result = _game.AddCards(otherPlayer.Object, card.Object);
        // Assert
        Assert.IsFalse(result);
        card.Verify(card => card.SetStatus(It.IsAny<CardStatus>()), Times.Never);
    }
}