using log4net;
using log4net.Config;
namespace GameControllerLib;

public class GameController
{
	private static readonly ILog log = LogManager.GetLogger(typeof(GameController));
	private Dictionary<IPlayer, HashSet<ICard>> _players;
	private IBoard _board;
	public event Action<ICard>? OnCardUpdate;

	public GameController(IPlayer player, IBoard board)
	{
		
		_players = new()
			{
				{ player, new HashSet<ICard>()}
			};
		_board = board;
		log.Info($"GameController created. Player: \"{player.GetName()}\", Board: {board.GetSize()} ");
	}

	public bool AddCards(IPlayer player, params ICard[] cards)
	{
		
		if (!_players.TryGetValue(player, out HashSet<ICard>? playerCards))
		{
			log.Error($"{player} is null");
			return false;
		}
		foreach (var card in cards)
		{
			playerCards.Add(card);
			ChangeCardStatus(card, CardStatus.OnPlayer);
		}
		log.Info($"Cards Added to: {player}");
		return true;
	}

	public IEnumerable<ICard> GetCards(IPlayer player)
	{
		if (!_players.ContainsKey(player))
		{
			log.Error($"{player} is empty");
			return Enumerable.Empty<ICard>();
		}
		log.Info($"{player.GetName()} get cards");
		return _players[player];
	}

	public bool RemoveCard(IPlayer player, ICard card)
	{
		if (!_players.ContainsKey(player))
		{
			log.Error($"{_players} doesn't contain {player}");
			return false;
		}

		if (!_players[player].Contains(card))
		{
			log.Error($"{_players[player]} doesn't contain {card}");
			return false;
		}
		_players[player].Remove(card);
		ChangeCardStatus(card, CardStatus.Removed);
		log.Info($"{card} removed & set status to Removed");
		return true;
	}

	public void ChangeCardStatus(ICard card, CardStatus status)
	{
		card.SetStatus(status);
		OnCardUpdate?.Invoke(card);
		log.Info("Update card & set card status");
	}
}
