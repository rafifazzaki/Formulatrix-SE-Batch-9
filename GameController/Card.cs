namespace GameControllerLib;
using log4net;
using log4net.Config;

public class Card : ICard
{
	private static readonly ILog log = LogManager.GetLogger(typeof(Card));
	private int _value;
	private string _description;
	private CardStatus _status;
	public Card(int value, string description) 
	{
		_value = value;
		_description = description;
	}
	public string GetDescription() 
	{
		return _description;
	}
	public int GetValue()
	{
		return _value;
	}
	public override bool Equals(object? obj)
	{
		if (obj is not ICard card)
		{
			log.Error("obj is not a Card");
			return false;
		}
		if (_value == card.GetValue())
		{
			log.Info($"{_value} & {card.GetValue()} is equal");
			return true;
		}
		return false;
	}
	public override int GetHashCode()
	{
		return _value;
	}

    public CardStatus GetStatus()
    {
		return _status;
    }

    public void SetStatus(CardStatus status)
    {
		log.Info($"Card Status {status}");
		_status = status;
    }
}
